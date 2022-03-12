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
    /// Zebra
    /// </summary>
    public partial class Zebra : Dictionary<String, Object>, IEquatable<Zebra>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Zebra" /> class.
        /// </summary>
        /// <param name="className">className (required)</param> allVars
        /// <param name="type">type</param> allVars
        public Zebra(string className, TypeEnum type = default) 
: base()
        {
            if (className == null)
                throw new ArgumentNullException("className is a required property for Zebra and cannot be null.");
            ClassName = className;
            Type = type;
        }

        /// <summary>
        /// Defines Type
        /// </summary>
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Plains for value: plains
            /// </summary>
            [EnumMember(Value = "plains")]
            Plains = 1,

            /// <summary>
            /// Enum Mountain for value: mountain
            /// </summary>
            [EnumMember(Value = "mountain")]
            Mountain = 2,

            /// <summary>
            /// Enum Grevys for value: grevys
            /// </summary>
            [EnumMember(Value = "grevys")]
            Grevys = 3

        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonPropertyName("type")]
        public TypeEnum Type { get; set; }

        /// <summary>
        /// Gets or Sets ClassName
        /// </summary>
        [JsonPropertyName("className")]
        public string ClassName { get; set; }
// required: true
// isNullable: false
// compulsory: true

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
            sb.Append("class Zebra {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as Zebra).AreEqual;
        }

        /// <summary>
        /// Returns true if Zebra instances are equal
        /// </summary>
        /// <param name="input">Instance of Zebra to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Zebra input)
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
                int hashCode = base.GetHashCode();
                if (this.ClassName != null)
                {
                    hashCode = (hashCode * 59) + this.ClassName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
