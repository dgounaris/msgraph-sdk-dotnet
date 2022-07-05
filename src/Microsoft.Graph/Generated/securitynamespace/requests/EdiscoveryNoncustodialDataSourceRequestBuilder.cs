// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type EdiscoveryNoncustodialDataSourceRequestBuilder.
    /// </summary>
    public partial class EdiscoveryNoncustodialDataSourceRequestBuilder : DataSourceContainerRequestBuilder, IEdiscoveryNoncustodialDataSourceRequestBuilder
    {

        /// <summary>
        /// Constructs a new EdiscoveryNoncustodialDataSourceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public EdiscoveryNoncustodialDataSourceRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IEdiscoveryNoncustodialDataSourceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IEdiscoveryNoncustodialDataSourceRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new EdiscoveryNoncustodialDataSourceRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for DataSource.
        /// </summary>
        /// <returns>The <see cref="IDataSourceRequestBuilder"/>.</returns>
        public IDataSourceRequestBuilder DataSource
        {
            get
            {
                return new DataSourceRequestBuilder(this.AppendSegmentToRequestUrl("dataSource"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for LastIndexOperation.
        /// </summary>
        /// <returns>The <see cref="IEdiscoveryIndexOperationWithReferenceRequestBuilder"/>.</returns>
        public IEdiscoveryIndexOperationWithReferenceRequestBuilder LastIndexOperation
        {
            get
            {
                return new EdiscoveryIndexOperationWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("lastIndexOperation"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for EdiscoveryNoncustodialDataSourceApplyHold.
        /// </summary>
        /// <returns>The <see cref="IEdiscoveryNoncustodialDataSourceApplyHoldRequestBuilder"/>.</returns>
        public IEdiscoveryNoncustodialDataSourceApplyHoldRequestBuilder ApplyHold()
        {
            return new EdiscoveryNoncustodialDataSourceApplyHoldRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.security.applyHold"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for EdiscoveryNoncustodialDataSourceRelease.
        /// </summary>
        /// <returns>The <see cref="IEdiscoveryNoncustodialDataSourceReleaseRequestBuilder"/>.</returns>
        public IEdiscoveryNoncustodialDataSourceReleaseRequestBuilder Release()
        {
            return new EdiscoveryNoncustodialDataSourceReleaseRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.security.release"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for EdiscoveryNoncustodialDataSourceRemoveHold.
        /// </summary>
        /// <returns>The <see cref="IEdiscoveryNoncustodialDataSourceRemoveHoldRequestBuilder"/>.</returns>
        public IEdiscoveryNoncustodialDataSourceRemoveHoldRequestBuilder RemoveHold()
        {
            return new EdiscoveryNoncustodialDataSourceRemoveHoldRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.security.removeHold"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for EdiscoveryNoncustodialDataSourceUpdateIndex.
        /// </summary>
        /// <returns>The <see cref="IEdiscoveryNoncustodialDataSourceUpdateIndexRequestBuilder"/>.</returns>
        public IEdiscoveryNoncustodialDataSourceUpdateIndexRequestBuilder UpdateIndex()
        {
            return new EdiscoveryNoncustodialDataSourceUpdateIndexRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.security.updateIndex"),
                this.Client);
        }
    
    }
}
