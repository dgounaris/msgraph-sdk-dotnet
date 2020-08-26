// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type UserManagedAppRegistrationsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class UserManagedAppRegistrationsCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IUserManagedAppRegistrationsCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new UserManagedAppRegistrationsCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserManagedAppRegistrationsCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUserManagedAppRegistrationsCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserManagedAppRegistrationsCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new UserManagedAppRegistrationsCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IManagedAppRegistrationWithReferenceRequestBuilder"/> for the specified UserManagedAppRegistration.
        /// </summary>
        /// <param name="id">The ID for the UserManagedAppRegistration.</param>
        /// <returns>The <see cref="IManagedAppRegistrationWithReferenceRequestBuilder"/>.</returns>
        public IManagedAppRegistrationWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new ManagedAppRegistrationWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IUserManagedAppRegistrationsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IUserManagedAppRegistrationsCollectionReferencesRequestBuilder"/>.</returns>
        public IUserManagedAppRegistrationsCollectionReferencesRequestBuilder References
        {
            get
            {
                return new UserManagedAppRegistrationsCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}