// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type AttendanceRecordRequest.
    /// </summary>
    public partial class AttendanceRecordRequest : BaseRequest, IAttendanceRecordRequest
    {
        /// <summary>
        /// Constructs a new AttendanceRecordRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AttendanceRecordRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AttendanceRecord using POST.
        /// </summary>
        /// <param name="attendanceRecordToCreate">The AttendanceRecord to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AttendanceRecord.</returns>
        public async System.Threading.Tasks.Task<AttendanceRecord> CreateAsync(AttendanceRecord attendanceRecordToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<AttendanceRecord>(attendanceRecordToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified AttendanceRecord using POST and returns a <see cref="GraphResponse{AttendanceRecord}"/> object.
        /// </summary>
        /// <param name="attendanceRecordToCreate">The AttendanceRecord to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AttendanceRecord}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AttendanceRecord>> CreateResponseAsync(AttendanceRecord attendanceRecordToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<AttendanceRecord>(attendanceRecordToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified AttendanceRecord.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<AttendanceRecord>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AttendanceRecord and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified AttendanceRecord.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AttendanceRecord.</returns>
        public async System.Threading.Tasks.Task<AttendanceRecord> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<AttendanceRecord>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified AttendanceRecord and returns a <see cref="GraphResponse{AttendanceRecord}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AttendanceRecord}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AttendanceRecord>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<AttendanceRecord>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AttendanceRecord using PATCH.
        /// </summary>
        /// <param name="attendanceRecordToUpdate">The AttendanceRecord to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AttendanceRecord.</returns>
        public async System.Threading.Tasks.Task<AttendanceRecord> UpdateAsync(AttendanceRecord attendanceRecordToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<AttendanceRecord>(attendanceRecordToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AttendanceRecord using PATCH and returns a <see cref="GraphResponse{AttendanceRecord}"/> object.
        /// </summary>
        /// <param name="attendanceRecordToUpdate">The AttendanceRecord to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AttendanceRecord}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AttendanceRecord>> UpdateResponseAsync(AttendanceRecord attendanceRecordToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<AttendanceRecord>(attendanceRecordToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AttendanceRecord using PUT.
        /// </summary>
        /// <param name="attendanceRecordToUpdate">The AttendanceRecord object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<AttendanceRecord> PutAsync(AttendanceRecord attendanceRecordToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<AttendanceRecord>(attendanceRecordToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AttendanceRecord using PUT and returns a <see cref="GraphResponse{AttendanceRecord}"/> object.
        /// </summary>
        /// <param name="attendanceRecordToUpdate">The AttendanceRecord object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{AttendanceRecord}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AttendanceRecord>> PutResponseAsync(AttendanceRecord attendanceRecordToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<AttendanceRecord>(attendanceRecordToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAttendanceRecordRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAttendanceRecordRequest Expand(Expression<Func<AttendanceRecord, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IAttendanceRecordRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAttendanceRecordRequest Select(Expression<Func<AttendanceRecord, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="attendanceRecordToInitialize">The <see cref="AttendanceRecord"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AttendanceRecord attendanceRecordToInitialize)
        {

        }
    }
}