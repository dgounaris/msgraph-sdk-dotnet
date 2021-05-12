// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IImportedWindowsAutopilotDeviceIdentityRequest.
    /// </summary>
    public partial interface IImportedWindowsAutopilotDeviceIdentityRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ImportedWindowsAutopilotDeviceIdentity using POST.
        /// </summary>
        /// <param name="importedWindowsAutopilotDeviceIdentityToCreate">The ImportedWindowsAutopilotDeviceIdentity to create.</param>
        /// <returns>The created ImportedWindowsAutopilotDeviceIdentity.</returns>
        System.Threading.Tasks.Task<ImportedWindowsAutopilotDeviceIdentity> CreateAsync(ImportedWindowsAutopilotDeviceIdentity importedWindowsAutopilotDeviceIdentityToCreate);        /// <summary>
        /// Creates the specified ImportedWindowsAutopilotDeviceIdentity using POST.
        /// </summary>
        /// <param name="importedWindowsAutopilotDeviceIdentityToCreate">The ImportedWindowsAutopilotDeviceIdentity to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ImportedWindowsAutopilotDeviceIdentity.</returns>
        System.Threading.Tasks.Task<ImportedWindowsAutopilotDeviceIdentity> CreateAsync(ImportedWindowsAutopilotDeviceIdentity importedWindowsAutopilotDeviceIdentityToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ImportedWindowsAutopilotDeviceIdentity.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ImportedWindowsAutopilotDeviceIdentity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ImportedWindowsAutopilotDeviceIdentity.
        /// </summary>
        /// <returns>The ImportedWindowsAutopilotDeviceIdentity.</returns>
        System.Threading.Tasks.Task<ImportedWindowsAutopilotDeviceIdentity> GetAsync();

        /// <summary>
        /// Gets the specified ImportedWindowsAutopilotDeviceIdentity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ImportedWindowsAutopilotDeviceIdentity.</returns>
        System.Threading.Tasks.Task<ImportedWindowsAutopilotDeviceIdentity> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ImportedWindowsAutopilotDeviceIdentity using PATCH.
        /// </summary>
        /// <param name="importedWindowsAutopilotDeviceIdentityToUpdate">The ImportedWindowsAutopilotDeviceIdentity to update.</param>
        /// <returns>The updated ImportedWindowsAutopilotDeviceIdentity.</returns>
        System.Threading.Tasks.Task<ImportedWindowsAutopilotDeviceIdentity> UpdateAsync(ImportedWindowsAutopilotDeviceIdentity importedWindowsAutopilotDeviceIdentityToUpdate);

        /// <summary>
        /// Updates the specified ImportedWindowsAutopilotDeviceIdentity using PATCH.
        /// </summary>
        /// <param name="importedWindowsAutopilotDeviceIdentityToUpdate">The ImportedWindowsAutopilotDeviceIdentity to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ImportedWindowsAutopilotDeviceIdentity.</returns>
        System.Threading.Tasks.Task<ImportedWindowsAutopilotDeviceIdentity> UpdateAsync(ImportedWindowsAutopilotDeviceIdentity importedWindowsAutopilotDeviceIdentityToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IImportedWindowsAutopilotDeviceIdentityRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IImportedWindowsAutopilotDeviceIdentityRequest Expand(Expression<Func<ImportedWindowsAutopilotDeviceIdentity, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IImportedWindowsAutopilotDeviceIdentityRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IImportedWindowsAutopilotDeviceIdentityRequest Select(Expression<Func<ImportedWindowsAutopilotDeviceIdentity, object>> selectExpression);

    }
}