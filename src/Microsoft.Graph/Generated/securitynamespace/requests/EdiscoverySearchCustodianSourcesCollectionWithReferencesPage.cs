// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionWithReferencesPage.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;

    /// <summary>
    /// The type EdiscoverySearchCustodianSourcesCollectionWithReferencesPage.
    /// </summary>
    public partial class EdiscoverySearchCustodianSourcesCollectionWithReferencesPage : Microsoft.Graph.CollectionPage<DataSource>, IEdiscoverySearchCustodianSourcesCollectionWithReferencesPage
    {
        /// <summary>
        /// Gets the next page <see cref="IEdiscoverySearchCustodianSourcesCollectionWithReferencesRequest"/> instance.
        /// </summary>
        public IEdiscoverySearchCustodianSourcesCollectionWithReferencesRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(Microsoft.Graph.IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new EdiscoverySearchCustodianSourcesCollectionWithReferencesRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
