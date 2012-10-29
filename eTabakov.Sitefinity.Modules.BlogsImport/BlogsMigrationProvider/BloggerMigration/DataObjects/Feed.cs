using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace eTabakov.Sitefinity.Modules.BlogsImport.BlogsMigrationProvider.BloggerMigration.DataObjects
{
    [XmlRoot(ElementName = "feed", Namespace = "http://www.w3.org/2005/Atom"), XmlType("feed")]
    public class Feed
    {
        [XmlElement("id")]
        public string Id { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("author")]
        public Author Author { get; set; }

        [XmlElement("entry")]
        public List<Entry> Entry;
    }
}
