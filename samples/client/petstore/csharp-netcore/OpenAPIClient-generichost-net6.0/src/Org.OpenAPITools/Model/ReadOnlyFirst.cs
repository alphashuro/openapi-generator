// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */



using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ReadOnlyFirst
    /// </summary>
    public partial class ReadOnlyFirst : IEquatable<ReadOnlyFirst>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadOnlyFirst" /> class.
        /// </summary>
        /// <param name="bar">bar</param>
        /// <param name="baz">baz</param>
        public ReadOnlyFirst(string bar, string baz)
        {
            Bar = bar;
            Baz = baz;
        }

        /// <summary>
        /// Gets or Sets Bar
        /// </summary>
        [JsonPropertyName("bar")]
        public string Bar { get; private set; }

        /// <summary>
        /// Gets or Sets Baz
        /// </summary>
        [JsonPropertyName("baz")]
        public string Baz { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; set; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReadOnlyFirst {\n");
            sb.Append("  Bar: ").Append(Bar).Append("\n");
            sb.Append("  Baz: ").Append(Baz).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input as ReadOnlyFirst).AreEqual;
        }

        /// <summary>
        /// Returns true if ReadOnlyFirst instances are equal
        /// </summary>
        /// <param name="input">Instance of ReadOnlyFirst to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReadOnlyFirst input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Bar != null)
                {
                    hashCode = (hashCode * 59) + this.Bar.GetHashCode();
                }
                if (this.Baz != null)
                {
                    hashCode = (hashCode * 59) + this.Baz.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
