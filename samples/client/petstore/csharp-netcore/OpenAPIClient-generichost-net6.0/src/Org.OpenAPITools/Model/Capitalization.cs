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
    /// Capitalization
    /// </summary>
    public partial class Capitalization : IEquatable<Capitalization>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Capitalization" /> class.
        /// </summary>
        /// <param name="smallCamel">smallCamel</param> allVars
        /// <param name="capitalCamel">capitalCamel</param> allVars
        /// <param name="smallSnake">smallSnake</param> allVars
        /// <param name="capitalSnake">capitalSnake</param> allVars
        /// <param name="sCAETHFlowPoints">sCAETHFlowPoints</param> allVars
        /// <param name="aTTNAME">Name of the pet </param> allVars
        public Capitalization(string smallCamel = default, string capitalCamel = default, string smallSnake = default, string capitalSnake = default, string sCAETHFlowPoints = default, string aTTNAME = default)
        {
            SmallCamel = smallCamel;
            CapitalCamel = capitalCamel;
            SmallSnake = smallSnake;
            CapitalSnake = capitalSnake;
            SCAETHFlowPoints = sCAETHFlowPoints;
            ATT_NAME = aTTNAME;
        }

        /// <summary>
        /// Gets or Sets SmallCamel
        /// </summary>
        [JsonPropertyName("smallCamel")]
        public string SmallCamel { get; set; }
// required: false
// isNullable: false
// compulsory: false

        /// <summary>
        /// Gets or Sets CapitalCamel
        /// </summary>
        [JsonPropertyName("CapitalCamel")]
        public string CapitalCamel { get; set; }
// required: false
// isNullable: false
// compulsory: false

        /// <summary>
        /// Gets or Sets SmallSnake
        /// </summary>
        [JsonPropertyName("small_Snake")]
        public string SmallSnake { get; set; }
// required: false
// isNullable: false
// compulsory: false

        /// <summary>
        /// Gets or Sets CapitalSnake
        /// </summary>
        [JsonPropertyName("Capital_Snake")]
        public string CapitalSnake { get; set; }
// required: false
// isNullable: false
// compulsory: false

        /// <summary>
        /// Gets or Sets SCAETHFlowPoints
        /// </summary>
        [JsonPropertyName("SCA_ETH_Flow_Points")]
        public string SCAETHFlowPoints { get; set; }
// required: false
// isNullable: false
// compulsory: false

        /// <summary>
        /// Name of the pet 
        /// </summary>
        /// <value>Name of the pet </value>
        [JsonPropertyName("ATT_NAME")]
        public string ATT_NAME { get; set; }
// required: false
// isNullable: false
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
            sb.Append("class Capitalization {\n");
            sb.Append("  SmallCamel: ").Append(SmallCamel).Append("\n");
            sb.Append("  CapitalCamel: ").Append(CapitalCamel).Append("\n");
            sb.Append("  SmallSnake: ").Append(SmallSnake).Append("\n");
            sb.Append("  CapitalSnake: ").Append(CapitalSnake).Append("\n");
            sb.Append("  SCAETHFlowPoints: ").Append(SCAETHFlowPoints).Append("\n");
            sb.Append("  ATT_NAME: ").Append(ATT_NAME).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as Capitalization).AreEqual;
        }

        /// <summary>
        /// Returns true if Capitalization instances are equal
        /// </summary>
        /// <param name="input">Instance of Capitalization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Capitalization input)
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
                if (this.SmallCamel != null)
                {
                    hashCode = (hashCode * 59) + this.SmallCamel.GetHashCode();
                }
                if (this.CapitalCamel != null)
                {
                    hashCode = (hashCode * 59) + this.CapitalCamel.GetHashCode();
                }
                if (this.SmallSnake != null)
                {
                    hashCode = (hashCode * 59) + this.SmallSnake.GetHashCode();
                }
                if (this.CapitalSnake != null)
                {
                    hashCode = (hashCode * 59) + this.CapitalSnake.GetHashCode();
                }
                if (this.SCAETHFlowPoints != null)
                {
                    hashCode = (hashCode * 59) + this.SCAETHFlowPoints.GetHashCode();
                }
                if (this.ATT_NAME != null)
                {
                    hashCode = (hashCode * 59) + this.ATT_NAME.GetHashCode();
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
