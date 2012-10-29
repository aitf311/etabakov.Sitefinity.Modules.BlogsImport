using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace eTabakov.Sitefinity.Modules.BlogsImport.BlogsMigrationProvider.BloggerMigration.DataObjects
{
    public class Author
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("email")]
        public string Email { get; set; }

        [XmlElement("uri")]
        public string Uri { get; set; }
    }
}
