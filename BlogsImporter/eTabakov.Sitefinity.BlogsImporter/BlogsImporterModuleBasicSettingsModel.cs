using System;
using System.Linq;
using System.Runtime.Serialization;
using Telerik.Sitefinity.Configuration;

namespace eTabakov.Sitefinity.BlogsImporter
{
    [DataContract]
    public class BlogsImporterModuleBasicSettingsModel
    {
        #region Construction
        /// <summary>
        /// Initializes a new instance of the <see cref="BlogsImporterModuleBasicSettingsModel"/> class.
        /// </summary>
        public BlogsImporterModuleBasicSettingsModel()
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
                return this.BlogsImporterModuleConfig.Text;
            }
            set
            {
                this.BlogsImporterModuleConfig.Text = value;
            }
        }

        /// <summary>
        /// Gets the reference to the BlogsImporterModule config.
        /// </summary>
        public BlogsImporterModuleConfig BlogsImporterModuleConfig
        {
            get
            {
                if (this.config == null)
                    this.config = Config.Get<BlogsImporterModuleConfig>();
                return this.config;
            }
        }
        #endregion

        #region Private fields and constants
        private BlogsImporterModuleConfig config;
        #endregion
    }
}