using System;
using System.Linq;
using System.Web.UI.WebControls;
using Telerik.Sitefinity;
using Telerik.Sitefinity.Abstractions;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Localization;
using Telerik.Sitefinity.Services;

namespace eTabakov.Sitefinity.Modules.BlogsImport
{
    public class BlogsImport : ModuleBase
    {
        #region Properties
        /// <summary>
        /// Gets the landing page id for each module inherit from <see cref="T:Telerik.Sitefinity.Services.SecuredModuleBase" /> class.
        /// </summary>
        /// <value>The landing page id.</value>
        public override Guid LandingPageId
        {
            get { return SiteInitializer.DashboardPageNodeId; }
        }

        /// <summary>
        /// Gets the CLR types of all data managers provided by this module.
        /// </summary>
        /// <value>An array of <see cref="T:System.Type" /> objects.</value>
        public override Type[] Managers
        {
            get { return BlogsImport.managerTypes; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Installs this module in Sitefinity system for the first time.
        /// </summary>
        /// <param name="initializer">The Site Initializer. A helper class for installing Sitefinity modules.</param>
        public override void Install(SiteInitializer initializer)
        {
            App.WorkWith().
                Module(BlogsImport.ModuleName, initializer.PageManager).Install()
                    .CreateModulePage(Guid.NewGuid(), "BlogsImport")
                        .SetOrdinal(1)
                        .LocalizeUsing<BlogsImportResources>()
                        .SetTitleLocalized("PageTitle")
                        .SetHtmlTitleLocalized("PageHtmlTitle")
                        .SetDescriptionLocalized("PageDescription")
                        .SetUrlNameLocalized("PageUrlName")
                        .AddControl(new Literal()
                        {
                            Text = "<h1 class=\"sfBreadCrumb\">Module BlogsImport Installed</h1>",
                            Mode = LiteralMode.PassThrough
                        })
                        .PlaceUnder(new Guid("f669d9a7-009d-4d83-ddaa-000000000004"))
                        .ShowInNavigation();
        }

        /// <summary>
        /// Initializes the service with specified settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        public override void Initialize(ModuleSettings settings)
        {
            base.Initialize(settings);
            App.WorkWith()
                .Module(BlogsImport.ModuleName)
                .Initialize()
                    .Configuration<BlogsImportConfig>()
                    .Localization<BlogsImportResources>()
                    .BasicSettings<BlogsImportBasicSettingsView>("BlogsImport", "BasicSettingsTitle", "BlogsImportResources");
        }

        /// <summary>
        /// Upgrades this module from the specified version.
        /// </summary>
        /// <param name="initializer">The Site Initializer. A helper class for installing
        /// Sitefinity modules.</param>
        /// <param name="upgradeFrom">The version this module us upgrading from.</param>
        public override void Upgrade(SiteInitializer initializer, Version upgradeFrom)
        {
        }

        /// <summary>
        /// Gets the module configuration.
        /// </summary>
        /// <returns></returns>
        protected override ConfigSection GetModuleConfig()
        {
            return Config.Get<BlogsImportConfig>();
        }
        #endregion

        #region Private members & constants
        /// <summary>
        /// Name of the module.
        /// </summary>
        public const string ModuleName = "BlogsImport";
        private static readonly Type[] managerTypes = null;
        #endregion
    }
}
