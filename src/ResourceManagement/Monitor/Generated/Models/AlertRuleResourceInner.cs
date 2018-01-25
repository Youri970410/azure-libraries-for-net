// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Fluent.Models
{
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The alert rule resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AlertRuleResourceInner : Resource
    {
        /// <summary>
        /// Initializes a new instance of the AlertRuleResourceInner class.
        /// </summary>
        public AlertRuleResourceInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AlertRuleResourceInner class.
        /// </summary>
        /// <param name="alertRuleResourceName">the name of the alert
        /// rule.</param>
        /// <param name="isEnabled">the flag that indicates whether the alert
        /// rule is enabled.</param>
        /// <param name="condition">the condition that results in the alert
        /// rule being activated.</param>
        /// <param name="description">the description of the alert rule that
        /// will be included in the alert email.</param>
        /// <param name="actions">the array of actions that are performed when
        /// the alert rule becomes active, and when an alert condition is
        /// resolved.</param>
        /// <param name="lastUpdatedTime">Last time the rule was updated in
        /// ISO8601 format.</param>
        public AlertRuleResourceInner(string alertRuleResourceName, bool isEnabled, RuleCondition condition, string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string description = default(string), IList<RuleAction> actions = default(IList<RuleAction>), System.DateTime? lastUpdatedTime = default(System.DateTime?))
            : base(location, id, name, type, tags)
        {
            AlertRuleResourceName = alertRuleResourceName;
            Description = description;
            IsEnabled = isEnabled;
            Condition = condition;
            Actions = actions;
            LastUpdatedTime = lastUpdatedTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the alert rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string AlertRuleResourceName { get; set; }

        /// <summary>
        /// Gets or sets the description of the alert rule that will be
        /// included in the alert email.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the flag that indicates whether the alert rule is
        /// enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isEnabled")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets the condition that results in the alert rule being
        /// activated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.condition")]
        public RuleCondition Condition { get; set; }

        /// <summary>
        /// Gets or sets the array of actions that are performed when the alert
        /// rule becomes active, and when an alert condition is resolved.
        /// </summary>
        [JsonProperty(PropertyName = "properties.actions")]
        public IList<RuleAction> Actions { get; set; }

        /// <summary>
        /// Gets last time the rule was updated in ISO8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastUpdatedTime")]
        public System.DateTime? LastUpdatedTime { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AlertRuleResourceName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AlertRuleResourceName");
            }
            if (Condition == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Condition");
            }
        }
    }
}
