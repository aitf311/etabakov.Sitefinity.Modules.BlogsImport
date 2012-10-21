using System;
using System.Configuration;
using System.Linq;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Localization;

namespace eTabakov.Sitefinity.Modules.BlogsImport
{
    [ObjectInfo(Title = "BlogsImport Config Title", Description = "BlogsImport Config Description")]
    public class BlogsImportConfig : ConfigSection
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