// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type EdiscoveryAddToReviewSetOperationRequest.
    /// </summary>
    public partial class EdiscoveryAddToReviewSetOperationRequest : Microsoft.Graph.BaseRequest, IEdiscoveryAddToReviewSetOperationRequest
    {
        /// <summary>
        /// Constructs a new EdiscoveryAddToReviewSetOperationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EdiscoveryAddToReviewSetOperationRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified EdiscoveryAddToReviewSetOperation using POST.
        /// </summary>
        /// <param name="ediscoveryAddToReviewSetOperationToCreate">The EdiscoveryAddToReviewSetOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EdiscoveryAddToReviewSetOperation.</returns>
        public async System.Threading.Tasks.Task<EdiscoveryAddToReviewSetOperation> CreateAsync(EdiscoveryAddToReviewSetOperation ediscoveryAddToReviewSetOperationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<EdiscoveryAddToReviewSetOperation>(ediscoveryAddToReviewSetOperationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified EdiscoveryAddToReviewSetOperation using POST and returns a <see cref="GraphResponse{EdiscoveryAddToReviewSetOperation}"/> object.
        /// </summary>
        /// <param name="ediscoveryAddToReviewSetOperationToCreate">The EdiscoveryAddToReviewSetOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EdiscoveryAddToReviewSetOperation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EdiscoveryAddToReviewSetOperation>> CreateResponseAsync(EdiscoveryAddToReviewSetOperation ediscoveryAddToReviewSetOperationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<EdiscoveryAddToReviewSetOperation>(ediscoveryAddToReviewSetOperationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified EdiscoveryAddToReviewSetOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<EdiscoveryAddToReviewSetOperation>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified EdiscoveryAddToReviewSetOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified EdiscoveryAddToReviewSetOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EdiscoveryAddToReviewSetOperation.</returns>
        public async System.Threading.Tasks.Task<EdiscoveryAddToReviewSetOperation> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<EdiscoveryAddToReviewSetOperation>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified EdiscoveryAddToReviewSetOperation and returns a <see cref="GraphResponse{EdiscoveryAddToReviewSetOperation}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EdiscoveryAddToReviewSetOperation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EdiscoveryAddToReviewSetOperation>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<EdiscoveryAddToReviewSetOperation>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified EdiscoveryAddToReviewSetOperation using PATCH.
        /// </summary>
        /// <param name="ediscoveryAddToReviewSetOperationToUpdate">The EdiscoveryAddToReviewSetOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EdiscoveryAddToReviewSetOperation.</returns>
        public async System.Threading.Tasks.Task<EdiscoveryAddToReviewSetOperation> UpdateAsync(EdiscoveryAddToReviewSetOperation ediscoveryAddToReviewSetOperationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<EdiscoveryAddToReviewSetOperation>(ediscoveryAddToReviewSetOperationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EdiscoveryAddToReviewSetOperation using PATCH and returns a <see cref="GraphResponse{EdiscoveryAddToReviewSetOperation}"/> object.
        /// </summary>
        /// <param name="ediscoveryAddToReviewSetOperationToUpdate">The EdiscoveryAddToReviewSetOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EdiscoveryAddToReviewSetOperation}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EdiscoveryAddToReviewSetOperation>> UpdateResponseAsync(EdiscoveryAddToReviewSetOperation ediscoveryAddToReviewSetOperationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<EdiscoveryAddToReviewSetOperation>(ediscoveryAddToReviewSetOperationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified EdiscoveryAddToReviewSetOperation using PUT.
        /// </summary>
        /// <param name="ediscoveryAddToReviewSetOperationToUpdate">The EdiscoveryAddToReviewSetOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<EdiscoveryAddToReviewSetOperation> PutAsync(EdiscoveryAddToReviewSetOperation ediscoveryAddToReviewSetOperationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<EdiscoveryAddToReviewSetOperation>(ediscoveryAddToReviewSetOperationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EdiscoveryAddToReviewSetOperation using PUT and returns a <see cref="GraphResponse{EdiscoveryAddToReviewSetOperation}"/> object.
        /// </summary>
        /// <param name="ediscoveryAddToReviewSetOperationToUpdate">The EdiscoveryAddToReviewSetOperation object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{EdiscoveryAddToReviewSetOperation}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EdiscoveryAddToReviewSetOperation>> PutResponseAsync(EdiscoveryAddToReviewSetOperation ediscoveryAddToReviewSetOperationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<EdiscoveryAddToReviewSetOperation>(ediscoveryAddToReviewSetOperationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoveryAddToReviewSetOperationRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoveryAddToReviewSetOperationRequest Expand(Expression<Func<EdiscoveryAddToReviewSetOperation, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoveryAddToReviewSetOperationRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoveryAddToReviewSetOperationRequest Select(Expression<Func<EdiscoveryAddToReviewSetOperation, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="ediscoveryAddToReviewSetOperationToInitialize">The <see cref="EdiscoveryAddToReviewSetOperation"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(EdiscoveryAddToReviewSetOperation ediscoveryAddToReviewSetOperationToInitialize)
        {

        }
    }
}
