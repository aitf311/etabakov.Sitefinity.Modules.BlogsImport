using System;
using System.Linq;
using Telerik.Sitefinity.Localization;
using Telerik.Sitefinity.Localization.Data;

namespace eTabakov.Sitefinity.BlogsImporter
{
    /// <summary>
    /// Localizable strings for the BlogsImporterModule module
    /// </summary>
    [ObjectInfo("BlogsImporterModuleResources", ResourceClassId = "BlogsImporterModuleResources", Title = "BlogsImporterModuleResourcesTitle", TitlePlural = "BlogsImporterModuleResourcesTitlePlural", Description = "BlogsImporterModuleResourcesDescription")]
    public class BlogsImporterModuleResources : Resource
    {
        #region Construction
        /// <summary>
        /// Initializes new instance of <see cref="BlogsImporterModuleResources"/> class with the default <see cref="ResourceDataProvider"/>.
        /// </summary>
        public BlogsImporterModuleResources()
        {
        }

        /// <summary>
        /// Initializes new instance of <see cref="BlogsImporterModuleResources"/> class with the provided <see cref="ResourceDataProvider"/>.
        /// </summary>
        /// <param name="dataProvider"><see cref="ResourceDataProvider"/></param>
        public BlogsImporterModuleResources(ResourceDataProvider dataProvider)
            : base(dataProvider)
        {
        }
        #endregion

        #region Class Description
        /// <summary>
        /// BlogsImporterModule Resources
        /// </summary>
        [ResourceEntry("BlogsImporterModuleResourcesTitle",
            Value = "BlogsImporterModule module labels",
            Description = "The title of this class.",
            LastModified = "2012/10/21")]
        public string BlogsImporterModuleResourcesTitle
        {
            get
            {
                return this["BlogsImporterModuleResourcesTitle"];
            }
        }

        /// <summary>
        /// BlogsImporterModule Resources Title plural
        /// </summary>
        [ResourceEntry("BlogsImporterModuleResourcesTitlePlural",
            Value = "BlogsImporterModule module labels",
            Description = "The title plural of this class.",
            LastModified = "2012/10/21")]
        public string BlogsImporterModuleResourcesTitlePlural
        {
            get
            {
                return this["BlogsImporterModuleResourcesTitlePlural"];
            }
        }

        /// <summary>
        /// Contains localizable resources for BlogsImporterModule module.
        /// </summary>
        [ResourceEntry("BlogsImporterModuleResourcesDescription",
            Value = "Contains localizable resources for BlogsImporterModule module.",
            Description = "The description of this class.",
            LastModified = "2012/10/21")]
        public string BlogsImporterModuleResourcesDescription
        {
            get
            {
                return this["BlogsImporterModuleResourcesDescription"];
            }
        }
        #endregion

        #region Resources
        /// <summary>
        /// Messsage: PageTitle
        /// </summary>
        /// <value>Title for the BlogsImporterModule's page.</value>
        [ResourceEntry("PageTitle",
            Value = "BlogsImporterModule",
            Description = "The title of BlogsImporterModule's page.",
            LastModified = "2012/10/21")]
        public string PageTitle
        {
            get
            {
                return this["PageTitle"];
            }
        }

        /// <summary>
        /// Messsage: PageHtmlTitle
        /// </summary>
        /// <value>Html title for the BlogsImporterModule's page.</value>
        [ResourceEntry("PageHtmlTitle",
            Value = "BlogsImporterModule",
            Description = "The html title of BlogsImporterModule's page.",
            LastModified = "2012/10/21")]
        public string PageHtmlTitle
        {
            get
            {
                return this["PageHtmlTitle"];
            }
        }

        /// <summary>
        /// Messsage: PageDescription
        /// </summary>
        /// <value>Description for the BlogsImporterModule's page.</value>
        [ResourceEntry("PageDescription",
            Value = "BlogsImporterModule",
            Description = "The description of BlogsImporterModule's page.",
            LastModified = "2012/10/21")]
        public string PageDescription
        {
            get
            {
                return this["PageDescription"];
            }
        }

        /// <summary>
        /// Messsage: PageUrlName
        /// </summary>
        /// <value>URL name for the BlogsImporterModule's page.</value>
        [ResourceEntry("PageUrlName",
            Value = "BlogsImporterModule",
            Description = "The URL name of BlogsImporterModule's page.",
            LastModified = "2012/10/21")]
        public string PageUrlName
        {
            get
            {
                return this["PageUrlName"];
            }
        }

        /// <summary>
        /// Messsage: BasicSettingsTitle
        /// </summary>
        /// <value>Title for the BlogsImporterModule's basic settings.</value>
        [ResourceEntry("BasicSettingsTitle",
            Value = "BlogsImporterModule",
            Description = "The title of BlogsImporterModule's basic settings.",
            LastModified = "2012/10/21")]
        public string BasicSettingsTitle
        {
            get
            {
                return this["BasicSettingsTitle"];
            }
        }

        /// <summary>
        /// Messsage: BasicSettingsHeader
        /// </summary>
        /// <value>Title for the BlogsImporterModule's basic settings header.</value>
        [ResourceEntry("BasicSettingsHeader",
            Value = "BlogsImporterModule",
            Description = "The title of BlogsImporterModule's basic settings header.",
            LastModified = "2012/10/21")]
        public string BasicSettingsHeader
        {
            get
            {
                return this["BasicSettingsHeader"];
            }
        }

        /// <summary>
        /// Messsage: SampleTextTitle
        /// </summary>
        /// <value>The title for the Sample Text text box in the basic settings.</value>
        [ResourceEntry("SampleTextTitle",
            Value = "Enter sample text:",
            Description = "The title for the Sample Text text box in the basic settings.",
            LastModified = "2012/10/21")]
        public string SampleTextTitle
        {
            get
            {
                return this["SampleTextTitle"];
            }
        }
        #endregion
    }
}