using System;
using System.Configuration;
using System.Linq;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Localization;

namespace eTabakov.Sitefinity.BlogsImporter
{
    [ObjectInfo(Title = "BlogsImporterModule Config Title", Description = "BlogsImporterModule Config Description")]
    public class BlogsImporterModuleConfig : ConfigSection
    {
        [ObjectInfo(Title = "Text", Description = "This is a sample string field.")]
        [ConfigurationProperty("Text", DefaultValue = "Hello, World!")]
        public string Text
        {
            get
            {
                return (string)this["Text"];
            }
            set
            {
                this["Text"] = value;
            }
        }
    }
}