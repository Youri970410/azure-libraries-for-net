// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An action group object for the body of patch operations.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ActionGroupPatchBodyInner
    {
        /// <summary>
        /// Initializes a new instance of the ActionGroupPatchBodyInner class.
        /// </summary>
        public ActionGroupPatchBodyInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActionGroupPatchBodyInner class.
        /// </summary>
        /// <param name="tags">Resource tags</param>
        /// <param name="enabled">Indicates whether this action group is
        /// enabled. If an action group is not enabled, then none of its
        /// actions will be activated.</param>
        public ActionGroupPatchBodyInner(IDictionary<string, string> tags = default(IDictionary<string, string>), bool? enabled = default(bool?))
        {
            Tags = tags;
            Enabled = enabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets indicates whether this action group is enabled. If an
        /// action group is not enabled, then none of its actions will be
        /// activated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabled")]
        public bool? Enabled { get; set; }

    }
}
