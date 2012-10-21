using System;
using System.Linq;
using Telerik.Sitefinity.Configuration.Web.UI.Basic;

namespace eTabakov.Sitefinity.BlogsImporter
{
    public class BlogsImporterModuleBasicSettingsView : BasicSettingsView
    {
        #region Properties
        /// <summary>
        /// Gets or sets the layout template path.
        /// </summary>
        /// <value>The layout template path.</value>
        public override string LayoutTemplatePath
        {
            get
            {
                if (string.IsNullOrEmpty(base.LayoutTemplatePath))
                {
                    return BlogsImporterModuleBasicSettingsView.layoutTemplatePath;
                }
                return base.LayoutTemplatePath;
            }
            set
            {
                base.LayoutTemplatePath = value;
            }
        }
        #endregion

        #region Private fields and constants
        private static readonly string layoutTemplatePath = "~/eTabakovSitefinityBlogsImporter/eTabakov.Sitefinity.BlogsImporter.BlogsImporterModuleBasicSettingsView.ascx";
        #endregion
    }
}