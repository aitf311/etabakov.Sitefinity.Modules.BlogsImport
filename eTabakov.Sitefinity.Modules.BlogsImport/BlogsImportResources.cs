using System;
using System.Linq;
using Telerik.Sitefinity.Localization;
using Telerik.Sitefinity.Localization.Data;

namespace eTabakov.Sitefinity.Modules.BlogsImport
{
    /// <summary>
    /// Localizable strings for the BlogsImport module
    /// </summary>
    [ObjectInfo("BlogsImportResources", ResourceClassId = "BlogsImportResources", Title = "BlogsImportResourcesTitle", TitlePlural = "BlogsImportResourcesTitlePlural", Description = "BlogsImportResourcesDescription")]
    public class BlogsImportResources : Resource
    {
        #region Construction
        /// <summary>
        /// Initializes new instance of <see cref="BlogsImportResources"/> class with the default <see cref="ResourceDataProvider"/>.
        /// </summary>
        public BlogsImportResources()
        {
        }

        /// <summary>
        /// Initializes new instance of <see cref="BlogsImportResources"/> class with the provided <see cref="ResourceDataProvider"/>.
        /// </summary>
        /// <param name="dataProvider"><see cref="ResourceDataProvider"/></param>
        public BlogsImportResources(ResourceDataProvider dataProvider)
            : base(dataProvider)
        {
        }
        #endregion

        #region Class Description
        /// <summary>
        /// BlogsImport Resources
        /// </summary>
        [ResourceEntry("BlogsImportResourcesTitle",
            Value = "BlogsImport module labels",
            Description = "The title of this class.",
            LastModified = "2012/10/21")]
        public string BlogsImportResourcesTitle
        {
            get
            {
                return this["BlogsImportResourcesTitle"];
            }
        }

        /// <summary>
        /// BlogsImport Resources Title plural
        /// </summary>
        [ResourceEntry("BlogsImportResourcesTitlePlural",
            Value = "BlogsImport module labels",
            Description = "The title plural of this class.",
            LastModified = "2012/10/21")]
        public string BlogsImportResourcesTitlePlural
        {
            get
            {
                return this["BlogsImportResourcesTitlePlural"];
            }
        }

        /// <summary>
        /// Contains localizable resources for BlogsImport module.
        /// </summary>
        [ResourceEntry("BlogsImportResourcesDescription",
            Value = "Contains localizable resources for BlogsImport module.",
            Description = "The description of this class.",
            LastModified = "2012/10/21")]
        public string BlogsImportResourcesDescription
        {
            get
            {
                return this["BlogsImportResourcesDescription"];
            }
        }
        #endregion

        #region Resources
        /// <summary>
        /// Messsage: PageTitle
        /// </summary>
        /// <value>Title for the BlogsImport's page.</value>
        [ResourceEntry("PageTitle",
            Value = "BlogsImport",
            Description = "The title of BlogsImport's page.",
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
        /// <value>Html title for the BlogsImport's page.</value>
        [ResourceEntry("PageHtmlTitle",
            Value = "BlogsImport",
            Description = "The html title of BlogsImport's page.",
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
        /// <value>Description for the BlogsImport's page.</value>
        [ResourceEntry("PageDescription",
            Value = "BlogsImport",
            Description = "The description of BlogsImport's page.",
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
        /// <value>URL name for the BlogsImport's page.</value>
        [ResourceEntry("PageUrlName",
            Value = "BlogsImport",
            Description = "The URL name of BlogsImport's page.",
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
        /// <value>Title for the BlogsImport's basic settings.</value>
        [ResourceEntry("BasicSettingsTitle",
            Value = "BlogsImport",
            Description = "The title of BlogsImport's basic settings.",
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
        /// <value>Title for the BlogsImport's basic settings header.</value>
        [ResourceEntry("BasicSettingsHeader",
            Value = "BlogsImport",
            Description = "The title of BlogsImport's basic settings header.",
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