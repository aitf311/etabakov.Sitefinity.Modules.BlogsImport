using System;
using System.Linq;
using Telerik.Sitefinity.Configuration.Web.UI.Basic;

namespace eTabakov.Sitefinity.Modules.BlogsImport
{
    public class BlogsImportBasicSettingsView : BasicSettingsView
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
                    return BlogsImportBasicSettingsView.layoutTemplatePath;
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
        private static readonly string layoutTemplatePath = "~/eTabakovSitefinityModulesBlogsImport/eTabakov.Sitefinity.Modules.BlogsImport.BlogsImportBasicSettingsView.ascx";
        #endregion
    }
}