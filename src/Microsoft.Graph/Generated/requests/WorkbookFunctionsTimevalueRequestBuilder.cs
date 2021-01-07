// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookFunctionsTimevalueRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsTimevalueRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsTimevalueRequest>, IWorkbookFunctionsTimevalueRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsTimevalueRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="timeText">A timeText parameter for the OData method call.</param>
        public WorkbookFunctionsTimevalueRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument timeText)
            : base(requestUrl, client)
        {
            this.SetParameter("timeText", timeText, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsTimevalueRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsTimevalueRequest(functionUrl, this.Client, options);

            if (this.HasParameter("timeText"))
            {
                request.RequestBody.TimeText = this.GetParameter<System.Text.Json.JsonDocument>("timeText");
            }

            return request;
        }
    }
}
