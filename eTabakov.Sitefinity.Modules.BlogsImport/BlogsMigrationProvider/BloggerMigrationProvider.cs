﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using Telerik.Sitefinity.Blogs.Model;
using Telerik.Sitefinity.Modules.Blogs;
using Telerik.Sitefinity.Workflow;
using eTabakov.Sitefinity.Modules.BlogsImport.BlogsMigrationProvider.BloggerMigration.DataObjects;
using Telerik.Sitefinity.GenericContent.Model;
using Telerik.Sitefinity.Taxonomies;
using Telerik.Sitefinity.Taxonomies.Model;

namespace eTabakov.Sitefinity.Modules.BlogsImport.BlogsMigrationProvider
{
    public class BloggerMigrationProvider : IBlogsMigrationProvider
    {
        public void MigrateBlogs(StreamReader source)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Feed));
            Feed feed = xmlSerializer.Deserialize(source) as Feed;

            BlogsManager blogsManager = BlogsManager.GetManager();
            Blog blog = blogsManager.CreateBlog();
            blog.Title = feed.Title;
            blog.Description = feed.Title;
            blog.UrlName = Regex.Replace(blog.Title.ToLower(), @"[^\w\-\!\$\'\(\)\=\@\d_]+", "-");

            blogsManager.SaveChanges();

            foreach (Entry post in feed.Entry.Where(en => en.Categories.Any(c => c.CategoryType == CategoryType.Post)))
            {
                migrateBlogPost(blogsManager, blog, post, feed);
            }
        }
  
        private void migrateBlogPost(BlogsManager blogsManager, Blog blog, Entry post, Feed feed)
        {
            BlogPost blogPost = blogsManager.CreateBlogPost();
            blogPost.Parent = blog;

            blogPost.Content = post.Content;
            blogPost.Title = post.Title;
            blogPost.DateCreated = post.Published;
            blogPost.PublicationDate = post.Published;
            blogPost.LastModified = post.Updated;
            blogPost.ItemDefaultUrl = "2012/06/net-guy-velocityconf-2012-day-1.html";
            blogsManager.SaveChanges();
            var bag = new Dictionary<string, string>();
            bag.Add("ContentType", typeof(BlogPost).FullName);
            WorkflowManager.MessageWorkflow(blogPost.Id, typeof(BlogPost), null, "Publish", false, bag);

            migrateComments(blogPost, blogsManager, post, feed);

            migrateTags(post, blogPost, blogsManager);
        }
  
        private void migrateComments(BlogPost blogPost, BlogsManager blogsManager, Entry post, Feed feed)
        {
            BlogPost livePost = blogsManager.GetLive(blogPost);

            foreach (Entry cmmnt in feed.Entry.Where(en => en.Categories.Any(c => c.CategoryType == CategoryType.Comment) && en.ReplyTo != null && en.ReplyTo.Id == post.Id))
            {
                Comment comment = blogsManager.CreateComment(livePost);
                comment.AuthorName = cmmnt.Author.Name;
                comment.Email = cmmnt.Author.Email;
                comment.Content = cmmnt.Content;
                comment.DateCreated = cmmnt.Published;

                blogsManager.SaveChanges();
            }
        }
  
        private void migrateTags(Entry post, BlogPost blogPost, BlogsManager blogsManager)
        {
            TaxonomyManager taxonomyManager = new TaxonomyManager();
            var tax = taxonomyManager.GetTaxonomies<FlatTaxonomy>().Where(t => t.Name == "Tags").SingleOrDefault();

            foreach (Category tag in post.Categories.Where(c => c.CategoryType == CategoryType.Unknown))
            {
                var taxon = taxonomyManager.GetTaxa<FlatTaxon>().Where(t => t.Title == tag.Term).FirstOrDefault();
                if (taxon == null)
                {
                    taxon = taxonomyManager.CreateTaxon<FlatTaxon>();
                    taxon.Name = tag.Term;
                    taxon.Title = tag.Term;

                    tax.Taxa.Add(taxon);
                    taxonomyManager.SaveChanges();
                }

                blogPost.Organizer.AddTaxa("Tags", taxon.Id);
                blogsManager.SaveChanges();
            }
        }

        public string SourceTitle
        {
            get
            {
                return "Blogger";
            }
        }
    }
}
