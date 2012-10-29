using System.Xml.Serialization;

namespace eTabakov.Sitefinity.Modules.BlogsImport.BlogsMigrationProvider.BloggerMigration.DataObjects
{
    public class Category
    {
        public CategoryType CategoryType
        {
            get
            {
                switch(Term)
                {
                    case "http://schemas.google.com/blogger/2008/kind#post":
                        return DataObjects.CategoryType.Post;
                    case "http://schemas.google.com/blogger/2008/kind#comment":
                        return DataObjects.CategoryType.Comment;
                    default:
                        return DataObjects.CategoryType.Unknown;
                }
            }
        }

        [XmlAttribute("term")]
        public string Term { get; set; }
    }
  
    public enum CategoryType
    {
        Unknown = 0,
        Post = 1,
        Comment = 2,
    }
}