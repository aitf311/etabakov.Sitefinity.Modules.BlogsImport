using System;
using System.Linq;
using System.Runtime.Serialization;
using Telerik.Sitefinity.Configuration;

namespace eTabakov.Sitefinity.Modules.BlogsImport
{
    [DataContract]
    public class BlogsImportBasicSettingsModel
    {
        #region Construction
        /// <summary>
        /// Initializes a new instance of the <see cref="BlogsImportBasicSettingsModel"/> class.
        /// </summary>
        public BlogsImportBasicSettingsModel()
        {
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the sample text.
        /// </summary>
        [DataMember]
        public string Text
        {
            get
            {
                return this.BlogsImportConfig.Text;
            }
            set
            {
                this.BlogsImportConfig.Text = value;
            }
        }

        /// <summary>
        /// Gets the reference to the BlogsImport config.
        /// </summary>
        public BlogsImportConfig BlogsImportConfig
        {
            get
            {
                if (this.config == null)
                    this.config = Config.Get<BlogsImportConfig>();
                return this.config;
            }
        }
        #endregion

        #region Private fields and constants
        private BlogsImportConfig config;
        #endregion
    }
}