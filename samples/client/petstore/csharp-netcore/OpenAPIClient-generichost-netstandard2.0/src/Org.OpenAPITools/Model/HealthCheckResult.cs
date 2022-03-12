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
    /// Just a string to inform instance is up and running. Make it nullable in hope to get it as pointer in generated model.
    /// </summary>
    public partial class HealthCheckResult : IEquatable<HealthCheckResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HealthCheckResult" /> class.
        /// </summary>
        /// <param name="nullableMessage">nullableMessage</param> allVars
        public HealthCheckResult(string nullableMessage = default)
        {
            NullableMessage = nullableMessage;
        }

        /// <summary>
        /// Gets or Sets NullableMessage
        /// </summary>
        [JsonPropertyName("NullableMessage")]
        public string NullableMessage { get; set; }
// required: false
// isNullable: true
// compulsory: false

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
            sb.Append("class HealthCheckResult {\n");
            sb.Append("  NullableMessage: ").Append(NullableMessage).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as HealthCheckResult).AreEqual;
        }

        /// <summary>
        /// Returns true if HealthCheckResult instances are equal
        /// </summary>
        /// <param name="input">Instance of HealthCheckResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HealthCheckResult input)
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
                if (this.NullableMessage != null)
                {
                    hashCode = (hashCode * 59) + this.NullableMessage.GetHashCode();
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
