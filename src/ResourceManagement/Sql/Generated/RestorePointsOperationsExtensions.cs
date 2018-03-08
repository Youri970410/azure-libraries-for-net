// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RestorePointsOperations.
    /// </summary>
    public static partial class RestorePointsOperationsExtensions
    {
            /// <summary>
            /// Gets a list of database restore points.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<RestorePointInner>> ListByDatabaseAsync(this IRestorePointsOperations operations, string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDatabaseWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a restore point for a data warehouse.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='restorePointLabel'>
            /// The restore point label to apply
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RestorePointInner> CreateAsync(this IRestorePointsOperations operations, string resourceGroupName, string serverName, string databaseName, string restorePointLabel, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, restorePointLabel, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a restore point.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='restorePointName'>
            /// The name of the restore point.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RestorePointInner> GetAsync(this IRestorePointsOperations operations, string resourceGroupName, string serverName, string databaseName, string restorePointName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, restorePointName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a restore point for a data warehouse.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='restorePointLabel'>
            /// The restore point label to apply
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RestorePointInner> BeginCreateAsync(this IRestorePointsOperations operations, string resourceGroupName, string serverName, string databaseName, string restorePointLabel, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, restorePointLabel, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
