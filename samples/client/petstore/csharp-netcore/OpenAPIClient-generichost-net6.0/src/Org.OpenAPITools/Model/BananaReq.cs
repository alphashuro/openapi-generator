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
    /// BananaReq
    /// </summary>
    public partial class BananaReq : IEquatable<BananaReq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BananaReq" /> class.
        /// </summary>
        /// <param name="lengthCm">lengthCm (required)</param> allVars
        /// <param name="sweet">sweet</param> allVars
        public BananaReq(decimal lengthCm, bool sweet = default)
        {
            if (lengthCm == null)
                throw new ArgumentNullException("lengthCm is a required property for BananaReq and cannot be null.");
            LengthCm = lengthCm;
            Sweet = sweet;
        }

        /// <summary>
        /// Gets or Sets LengthCm
        /// </summary>
        [JsonPropertyName("lengthCm")]
        public decimal LengthCm { get; set; }
// required: true
// isNullable: false
// compulsory: true

        /// <summary>
        /// Gets or Sets Sweet
        /// </summary>
        [JsonPropertyName("sweet")]
        public bool Sweet { get; set; }
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
            sb.Append("class BananaReq {\n");
            sb.Append("  LengthCm: ").Append(LengthCm).Append("\n");
            sb.Append("  Sweet: ").Append(Sweet).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as BananaReq).AreEqual;
        }

        /// <summary>
        /// Returns true if BananaReq instances are equal
        /// </summary>
        /// <param name="input">Instance of BananaReq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BananaReq input)
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
                hashCode = (hashCode * 59) + this.LengthCm.GetHashCode();
                hashCode = (hashCode * 59) + this.Sweet.GetHashCode();
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
