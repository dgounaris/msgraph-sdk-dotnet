// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Site.
    /// </summary>
    public partial class Site : BaseItem
    {
    
        ///<summary>
        /// The Site constructor
        ///</summary>
        public Site()
        {
            this.ODataType = "microsoft.graph.site";
        }

        /// <summary>
        /// Gets or sets display name.
        /// The full title for the site. Read-only.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets error.
        /// </summary>
        [JsonPropertyName("error")]
        public PublicError Error { get; set; }
    
        /// <summary>
        /// Gets or sets root.
        /// If present, indicates that this is the root site in the site collection. Read-only.
        /// </summary>
        [JsonPropertyName("root")]
        public Root Root { get; set; }
    
        /// <summary>
        /// Gets or sets sharepoint ids.
        /// Returns identifiers useful for SharePoint REST compatibility. Read-only.
        /// </summary>
        [JsonPropertyName("sharepointIds")]
        public SharepointIds SharepointIds { get; set; }
    
        /// <summary>
        /// Gets or sets site collection.
        /// Provides details about the site's site collection. Available only on the root site. Read-only.
        /// </summary>
        [JsonPropertyName("siteCollection")]
        public SiteCollection SiteCollection { get; set; }
    
        /// <summary>
        /// Gets or sets analytics.
        /// Analytics about the view activities that took place in this site.
        /// </summary>
        [JsonPropertyName("analytics")]
        public ItemAnalytics Analytics { get; set; }
    
        /// <summary>
        /// Gets or sets columns.
        /// The collection of column definitions reusable across lists under this site.
        /// </summary>
        [JsonPropertyName("columns")]
        public ISiteColumnsCollectionPage Columns { get; set; }

        /// <summary>
        /// Gets or sets columnsNextLink.
        /// </summary>
        [JsonPropertyName("columns@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ColumnsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets content types.
        /// The collection of content types defined for this site.
        /// </summary>
        [JsonPropertyName("contentTypes")]
        public ISiteContentTypesCollectionPage ContentTypes { get; set; }

        /// <summary>
        /// Gets or sets contentTypesNextLink.
        /// </summary>
        [JsonPropertyName("contentTypes@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ContentTypesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets drive.
        /// The default drive (document library) for this site.
        /// </summary>
        [JsonPropertyName("drive")]
        public Drive Drive { get; set; }
    
        /// <summary>
        /// Gets or sets drives.
        /// The collection of drives (document libraries) under this site.
        /// </summary>
        [JsonPropertyName("drives")]
        public ISiteDrivesCollectionPage Drives { get; set; }

        /// <summary>
        /// Gets or sets drivesNextLink.
        /// </summary>
        [JsonPropertyName("drives@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DrivesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets external columns.
        /// The collection of column definitions available in the site that are referenced from the sites in the parent hierarchy of the current site.
        /// </summary>
        [JsonPropertyName("externalColumns")]
        public ISiteExternalColumnsCollectionWithReferencesPage ExternalColumns { get; set; }

        /// <summary>
        /// Gets or sets externalColumnsNextLink.
        /// </summary>
        [JsonPropertyName("externalColumns@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ExternalColumnsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets items.
        /// Used to address any item contained in this site. This collection cannot be enumerated.
        /// </summary>
        [JsonPropertyName("items")]
        public ISiteItemsCollectionPage Items { get; set; }

        /// <summary>
        /// Gets or sets itemsNextLink.
        /// </summary>
        [JsonPropertyName("items@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ItemsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets lists.
        /// The collection of lists under this site.
        /// </summary>
        [JsonPropertyName("lists")]
        public ISiteListsCollectionPage Lists { get; set; }

        /// <summary>
        /// Gets or sets listsNextLink.
        /// </summary>
        [JsonPropertyName("lists@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ListsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets permissions.
        /// The permissions associated with the site. Nullable.
        /// </summary>
        [JsonPropertyName("permissions")]
        public ISitePermissionsCollectionPage Permissions { get; set; }

        /// <summary>
        /// Gets or sets permissionsNextLink.
        /// </summary>
        [JsonPropertyName("permissions@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string PermissionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets sites.
        /// The collection of the sub-sites under this site.
        /// </summary>
        [JsonPropertyName("sites")]
        public ISiteSitesCollectionPage Sites { get; set; }

        /// <summary>
        /// Gets or sets sitesNextLink.
        /// </summary>
        [JsonPropertyName("sites@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string SitesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets term store.
        /// The termStore under this site.
        /// </summary>
        [JsonPropertyName("termStore")]
        public Microsoft.Graph.TermStore.Store TermStore { get; set; }
    
        /// <summary>
        /// Gets or sets term stores.
        /// The collection of termStores under this site.
        /// </summary>
        [JsonPropertyName("termStores")]
        public ISiteTermStoresCollectionPage TermStores { get; set; }

        /// <summary>
        /// Gets or sets termStoresNextLink.
        /// </summary>
        [JsonPropertyName("termStores@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string TermStoresNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets onenote.
        /// Calls the OneNote service for notebook related operations.
        /// </summary>
        [JsonPropertyName("onenote")]
        public Onenote Onenote { get; set; }
    
    }
}

