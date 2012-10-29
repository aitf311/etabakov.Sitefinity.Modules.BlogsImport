using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace eTabakov.Sitefinity.Modules.BlogsImport.BlogsMigrationProvider.BloggerMigration.DataObjects
{
    public class Entry
    {
        [XmlElement("id")]
        public string Id { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("content")]
        public string Content { get; set; }

        [XmlElement("published")]
        public DateTime Published { get; set; }

        [XmlElement("updated")]
        public DateTime Updated { get; set; }

        [XmlElement("category")]
        public List<Category> Categories;

        [XmlElement("author")]
        public Author Author { get; set; }

        [XmlElement(ElementName = "in-reply-to", Namespace = "thr", Type = typeof(ReplyTo), IsNullable = true)]
        public ReplyTo ReplyTo { get; set; }
    }

    public class ReplyTo
    {
        [XmlAttribute("ref")]
        public string Id { get; set; }
    }
}