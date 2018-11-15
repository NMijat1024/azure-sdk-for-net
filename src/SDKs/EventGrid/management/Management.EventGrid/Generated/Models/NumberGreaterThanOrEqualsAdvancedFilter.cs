// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// NumberGreaterThanOrEquals Filter
    /// </summary>
    [Newtonsoft.Json.JsonObject("NumberGreaterThanOrEquals")]
    public partial class NumberGreaterThanOrEqualsAdvancedFilter : AdvancedFilter
    {
        /// <summary>
        /// Initializes a new instance of the
        /// NumberGreaterThanOrEqualsAdvancedFilter class.
        /// </summary>
        public NumberGreaterThanOrEqualsAdvancedFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// NumberGreaterThanOrEqualsAdvancedFilter class.
        /// </summary>
        /// <param name="key">The filter key. Represents an event property with
        /// upto two levels of nesting.</param>
        /// <param name="value">The filter value</param>
        public NumberGreaterThanOrEqualsAdvancedFilter(string key = default(string), double? value = default(double?))
            : base(key)
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the filter value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public double? Value { get; set; }

    }
}
