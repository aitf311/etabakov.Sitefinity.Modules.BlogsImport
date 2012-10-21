using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Utilities.MS.ServiceModel.Web;
using Telerik.Sitefinity.Web.Services;

namespace eTabakov.Sitefinity.BlogsImporter
{
    /// <summary>
    /// WCF Rest service for config policies.
    /// </summary>
    [ServiceBehavior(IncludeExceptionDetailInFaults = true, InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    [ServiceContract]
    public class BlogsImporterModuleBasicSettingsService
    {
        ///<summary>
        /// Get the BlogsImporterModule config
        ///</summary>
        [WebHelp(Comment = "Get the BlogsImporterModule config.")]
        [WebInvoke(Method = "GET", UriTemplate = "config/", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        public BlogsImporterModuleBasicSettingsModel GetBlogsImporterModuleConfig()
        {
            ServiceUtility.RequestAuthentication();
            return new BlogsImporterModuleBasicSettingsModel();
        }

        /// <summary>
        /// Saves the BlogsImporterModule config
        /// </summary>
        [WebHelp(Comment = "Save the BlogsImporterModule config.")]
        [WebInvoke(Method = "PUT", UriTemplate = "config/{key}/", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        public void SaveBlogsImporterModuleConfig(ItemContext<BlogsImporterModuleBasicSettingsModel> settings, string key)
        {
            ServiceUtility.RequestAuthentication();
            var manager = ConfigManager.GetManager();
            manager.SaveSection(settings.Item.BlogsImporterModuleConfig);
        }
    }
}
