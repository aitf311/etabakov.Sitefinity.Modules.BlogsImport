using System;
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
