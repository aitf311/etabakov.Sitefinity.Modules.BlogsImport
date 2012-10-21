using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Utilities.MS.ServiceModel.Web;
using Telerik.Sitefinity.Web.Services;

namespace eTabakov.Sitefinity.Modules.BlogsImport
{
    /// <summary>
    /// WCF Rest service for config policies.
    /// </summary>
    [ServiceBehavior(IncludeExceptionDetailInFaults = true, InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    [ServiceContract]
    public class BlogsImportBasicSettingsService
    {
        ///<summary>
        /// Get the BlogsImport config
        ///</summary>
        [WebHelp(Comment = "Get the BlogsImport config.")]
        [WebInvoke(Method = "GET", UriTemplate = "config/", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        public BlogsImportBasicSettingsModel GetBlogsImportConfig()
        {
            ServiceUtility.RequestAuthentication();
            return new BlogsImportBasicSettingsModel();
        }

        /// <summary>
        /// Saves the BlogsImport config
        /// </summary>
        [WebHelp(Comment = "Save the BlogsImport config.")]
        [WebInvoke(Method = "PUT", UriTemplate = "config/{key}/", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        public void SaveBlogsImportConfig(ItemContext<BlogsImportBasicSettingsModel> settings, string key)
        {
            ServiceUtility.RequestAuthentication();
            var manager = ConfigManager.GetManager();
            manager.SaveSection(settings.Item.BlogsImportConfig);
        }
    }
}
