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
    /// AppleReq
    /// </summary>
    public partial class AppleReq : IEquatable<AppleReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppleReq" /> class.
        /// </summary>
        /// <param name="cultivar">cultivar (required)</param> allVars
        /// <param name="mealy">mealy</param> allVars
        public AppleReq(string cultivar, bool mealy = default)
        {
            if (cultivar == null)
                throw new ArgumentNullException("cultivar is a required property for AppleReq and cannot be null.");
            Cultivar = cultivar;
            Mealy = mealy;
        }

        /// <summary>
        /// Gets or Sets Cultivar
        /// </summary>
        [JsonPropertyName("cultivar")]
        public string Cultivar { get; set; }
// required: true
// isNullable: false
// compulsory: true

        /// <summary>
        /// Gets or Sets Mealy
        /// </summary>
        [JsonPropertyName("mealy")]
        public bool Mealy { get; set; }
// required: false
// isNullable: false
// compulsory: false

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppleReq {\n");
            sb.Append("  Cultivar: ").Append(Cultivar).Append("\n");
            sb.Append("  Mealy: ").Append(Mealy).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as AppleReq).AreEqual;
        }

        /// <summary>
        /// Returns true if AppleReq instances are equal
        /// </summary>
        /// <param name="input">Instance of AppleReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppleReq input)
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
                if (this.Cultivar != null)
                {
                    hashCode = (hashCode * 59) + this.Cultivar.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Mealy.GetHashCode();
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
