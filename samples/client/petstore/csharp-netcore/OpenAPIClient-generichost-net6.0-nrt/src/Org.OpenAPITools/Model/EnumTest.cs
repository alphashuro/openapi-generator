// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

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
    /// EnumTest
    /// </summary>
    public partial class EnumTest : IEquatable<EnumTest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumTest" /> class.
        /// </summary>
        /// <param name="enumStringRequired">enumStringRequired (required)</param>
        /// <param name="enumString">enumString</param>
        /// <param name="enumInteger">enumInteger</param>
        /// <param name="enumIntegerOnly">enumIntegerOnly</param>
        /// <param name="enumNumber">enumNumber</param>
        /// <param name="outerEnum">outerEnum</param>
        /// <param name="outerEnumInteger">outerEnumInteger</param>
        /// <param name="outerEnumDefaultValue">outerEnumDefaultValue</param>
        /// <param name="outerEnumIntegerDefaultValue">outerEnumIntegerDefaultValue</param>
        public EnumTest(EnumStringRequiredEnum enumStringRequired, EnumStringEnum enumString, EnumIntegerEnum enumInteger, EnumIntegerOnlyEnum enumIntegerOnly, EnumNumberEnum enumNumber, OuterEnum? outerEnum = default, OuterEnumInteger outerEnumInteger, OuterEnumDefaultValue outerEnumDefaultValue, OuterEnumIntegerDefaultValue outerEnumIntegerDefaultValue)
        {
            if (enumStringRequired == null)
                throw new ArgumentNullException("enumStringRequired is a required property for EnumTest and cannot be null.");
            EnumStringRequired = enumStringRequired;
            EnumString = enumString;
            EnumInteger = enumInteger;
            EnumIntegerOnly = enumIntegerOnly;
            EnumNumber = enumNumber;
            OuterEnum = outerEnum;
            OuterEnumInteger = outerEnumInteger;
            OuterEnumDefaultValue = outerEnumDefaultValue;
            OuterEnumIntegerDefaultValue = outerEnumIntegerDefaultValue;
        }

        /// <summary>
        /// Defines EnumStringRequired
        /// </summary>
        public enum EnumStringRequiredEnum
        {
            /// <summary>
            /// Enum UPPER for value: UPPER
            /// </summary>
            [EnumMember(Value = "UPPER")]
            UPPER = 1,

            /// <summary>
            /// Enum Lower for value: lower
            /// </summary>
            [EnumMember(Value = "lower")]
            Lower = 2,

            /// <summary>
            /// Enum Empty for value: 
            /// </summary>
            [EnumMember(Value = "")]
            Empty = 3

        }

        /// <summary>
        /// Gets or Sets EnumStringRequired
        /// </summary>
        [JsonPropertyName("enum_string_required")]
        public EnumStringRequiredEnum EnumStringRequired { get; set; }
        
        /// <summary>
        /// Defines EnumString
        /// </summary>
        public enum EnumStringEnum
        {
            /// <summary>
            /// Enum UPPER for value: UPPER
            /// </summary>
            [EnumMember(Value = "UPPER")]
            UPPER = 1,

            /// <summary>
            /// Enum Lower for value: lower
            /// </summary>
            [EnumMember(Value = "lower")]
            Lower = 2,

            /// <summary>
            /// Enum Empty for value: 
            /// </summary>
            [EnumMember(Value = "")]
            Empty = 3

        }

        /// <summary>
        /// Gets or Sets EnumString
        /// </summary>
        [JsonPropertyName("enum_string")]
        public EnumStringEnum? EnumString { get; set; }
        
        /// <summary>
        /// Defines EnumInteger
        /// </summary>
        public enum EnumIntegerEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_MINUS_1 for value: -1
            /// </summary>
            NUMBER_MINUS_1 = -1

        }

        /// <summary>
        /// Gets or Sets EnumInteger
        /// </summary>
        [JsonPropertyName("enum_integer")]
        public EnumIntegerEnum? EnumInteger { get; set; }
        
        /// <summary>
        /// Defines EnumIntegerOnly
        /// </summary>
        public enum EnumIntegerOnlyEnum
        {
            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2,

            /// <summary>
            /// Enum NUMBER_MINUS_2 for value: -2
            /// </summary>
            NUMBER_MINUS_2 = -2

        }

        /// <summary>
        /// Gets or Sets EnumIntegerOnly
        /// </summary>
        [JsonPropertyName("enum_integer_only")]
        public EnumIntegerOnlyEnum? EnumIntegerOnly { get; set; }
        
        /// <summary>
        /// Defines EnumNumber
        /// </summary>
        public enum EnumNumberEnum
        {
            /// <summary>
            /// Enum NUMBER_1_DOT_1 for value: 1.1
            /// </summary>
            [EnumMember(Value = "1.1")]
            NUMBER_1_DOT_1 = 1,

            /// <summary>
            /// Enum NUMBER_MINUS_1_DOT_2 for value: -1.2
            /// </summary>
            [EnumMember(Value = "-1.2")]
            NUMBER_MINUS_1_DOT_2 = 2

        }

        /// <summary>
        /// Gets or Sets EnumNumber
        /// </summary>
        [JsonPropertyName("enum_number")]
        public EnumNumberEnum? EnumNumber { get; set; }
        
        /// <summary>
        /// Gets or Sets OuterEnum
        /// </summary>
        [JsonPropertyName("outerEnum")]
        public OuterEnum? OuterEnum { get; set; }
        
        /// <summary>
        /// Gets or Sets OuterEnumInteger
        /// </summary>
        [JsonPropertyName("outerEnumInteger")]
        public OuterEnumInteger? OuterEnumInteger { get; set; }
        
        /// <summary>
        /// Gets or Sets OuterEnumDefaultValue
        /// </summary>
        [JsonPropertyName("outerEnumDefaultValue")]
        public OuterEnumDefaultValue? OuterEnumDefaultValue { get; set; }
        
        /// <summary>
        /// Gets or Sets OuterEnumIntegerDefaultValue
        /// </summary>
        [JsonPropertyName("outerEnumIntegerDefaultValue")]
        public OuterEnumIntegerDefaultValue? OuterEnumIntegerDefaultValue { get; set; }
        
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
            sb.Append("class EnumTest {\n");
            sb.Append("  EnumStringRequired: ").Append(EnumStringRequired).Append("\n");
            sb.Append("  EnumString: ").Append(EnumString).Append("\n");
            sb.Append("  EnumInteger: ").Append(EnumInteger).Append("\n");
            sb.Append("  EnumIntegerOnly: ").Append(EnumIntegerOnly).Append("\n");
            sb.Append("  EnumNumber: ").Append(EnumNumber).Append("\n");
            sb.Append("  OuterEnum: ").Append(OuterEnum).Append("\n");
            sb.Append("  OuterEnumInteger: ").Append(OuterEnumInteger).Append("\n");
            sb.Append("  OuterEnumDefaultValue: ").Append(OuterEnumDefaultValue).Append("\n");
            sb.Append("  OuterEnumIntegerDefaultValue: ").Append(OuterEnumIntegerDefaultValue).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object? input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input as EnumTest).AreEqual;
        }

        /// <summary>
        /// Returns true if EnumTest instances are equal
        /// </summary>
        /// <param name="input">Instance of EnumTest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnumTest? input)
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
                hashCode = (hashCode * 59) + this.EnumStringRequired.GetHashCode();
                hashCode = (hashCode * 59) + this.EnumString.GetHashCode();
                hashCode = (hashCode * 59) + this.EnumInteger.GetHashCode();
                hashCode = (hashCode * 59) + this.EnumIntegerOnly.GetHashCode();
                hashCode = (hashCode * 59) + this.EnumNumber.GetHashCode();
                hashCode = (hashCode * 59) + this.OuterEnum.GetHashCode();
                hashCode = (hashCode * 59) + this.OuterEnumInteger.GetHashCode();
                hashCode = (hashCode * 59) + this.OuterEnumDefaultValue.GetHashCode();
                hashCode = (hashCode * 59) + this.OuterEnumIntegerDefaultValue.GetHashCode();
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
