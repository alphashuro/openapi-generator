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
    /// AdditionalPropertiesClass
    /// </summary>
    public partial class AdditionalPropertiesClass : IEquatable<AdditionalPropertiesClass>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalPropertiesClass" /> class.
        /// </summary>
        /// <param name="mapProperty">mapProperty</param>
        /// <param name="mapOfMapProperty">mapOfMapProperty</param>
        /// <param name="anytype1">anytype1</param>
        /// <param name="mapWithUndeclaredPropertiesAnytype1">mapWithUndeclaredPropertiesAnytype1</param>
        /// <param name="mapWithUndeclaredPropertiesAnytype2">mapWithUndeclaredPropertiesAnytype2</param>
        /// <param name="mapWithUndeclaredPropertiesAnytype3">mapWithUndeclaredPropertiesAnytype3</param>
        /// <param name="emptyMap">an object with no declared properties and no undeclared properties, hence it&#39;s an empty map.</param>
        /// <param name="mapWithUndeclaredPropertiesString">mapWithUndeclaredPropertiesString</param>
        public AdditionalPropertiesClass(Dictionary<string, string> mapProperty, Dictionary<string, Dictionary<string, string>> mapOfMapProperty, Object? anytype1 = default, Object mapWithUndeclaredPropertiesAnytype1, Object mapWithUndeclaredPropertiesAnytype2, Dictionary<string, Object> mapWithUndeclaredPropertiesAnytype3, Object emptyMap, Dictionary<string, string> mapWithUndeclaredPropertiesString)
        {
            MapProperty = mapProperty;
            MapOfMapProperty = mapOfMapProperty;
            Anytype1 = anytype1;
            MapWithUndeclaredPropertiesAnytype1 = mapWithUndeclaredPropertiesAnytype1;
            MapWithUndeclaredPropertiesAnytype2 = mapWithUndeclaredPropertiesAnytype2;
            MapWithUndeclaredPropertiesAnytype3 = mapWithUndeclaredPropertiesAnytype3;
            EmptyMap = emptyMap;
            MapWithUndeclaredPropertiesString = mapWithUndeclaredPropertiesString;
        }

        /// <summary>
        /// Gets or Sets MapProperty
        /// </summary>
        [JsonPropertyName("map_property")]
        public Dictionary<string, string> MapProperty { get; set; }

        /// <summary>
        /// Gets or Sets MapOfMapProperty
        /// </summary>
        [JsonPropertyName("map_of_map_property")]
        public Dictionary<string, Dictionary<string, string>> MapOfMapProperty { get; set; }

        /// <summary>
        /// Gets or Sets Anytype1
        /// </summary>
        [JsonPropertyName("anytype_1")]
        public Object? Anytype1 { get; set; }

        /// <summary>
        /// Gets or Sets MapWithUndeclaredPropertiesAnytype1
        /// </summary>
        [JsonPropertyName("map_with_undeclared_properties_anytype_1")]
        public Object MapWithUndeclaredPropertiesAnytype1 { get; set; }

        /// <summary>
        /// Gets or Sets MapWithUndeclaredPropertiesAnytype2
        /// </summary>
        [JsonPropertyName("map_with_undeclared_properties_anytype_2")]
        public Object MapWithUndeclaredPropertiesAnytype2 { get; set; }

        /// <summary>
        /// Gets or Sets MapWithUndeclaredPropertiesAnytype3
        /// </summary>
        [JsonPropertyName("map_with_undeclared_properties_anytype_3")]
        public Dictionary<string, Object> MapWithUndeclaredPropertiesAnytype3 { get; set; }

        /// <summary>
        /// an object with no declared properties and no undeclared properties, hence it&#39;s an empty map.
        /// </summary>
        /// <value>an object with no declared properties and no undeclared properties, hence it&#39;s an empty map.</value>
        [JsonPropertyName("empty_map")]
        public Object EmptyMap { get; set; }

        /// <summary>
        /// Gets or Sets MapWithUndeclaredPropertiesString
        /// </summary>
        [JsonPropertyName("map_with_undeclared_properties_string")]
        public Dictionary<string, string> MapWithUndeclaredPropertiesString { get; set; }

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
            sb.Append("class AdditionalPropertiesClass {\n");
            sb.Append("  MapProperty: ").Append(MapProperty).Append("\n");
            sb.Append("  MapOfMapProperty: ").Append(MapOfMapProperty).Append("\n");
            sb.Append("  Anytype1: ").Append(Anytype1).Append("\n");
            sb.Append("  MapWithUndeclaredPropertiesAnytype1: ").Append(MapWithUndeclaredPropertiesAnytype1).Append("\n");
            sb.Append("  MapWithUndeclaredPropertiesAnytype2: ").Append(MapWithUndeclaredPropertiesAnytype2).Append("\n");
            sb.Append("  MapWithUndeclaredPropertiesAnytype3: ").Append(MapWithUndeclaredPropertiesAnytype3).Append("\n");
            sb.Append("  EmptyMap: ").Append(EmptyMap).Append("\n");
            sb.Append("  MapWithUndeclaredPropertiesString: ").Append(MapWithUndeclaredPropertiesString).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as AdditionalPropertiesClass).AreEqual;
        }

        /// <summary>
        /// Returns true if AdditionalPropertiesClass instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalPropertiesClass to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalPropertiesClass? input)
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
                if (this.MapProperty != null)
                {
                    hashCode = (hashCode * 59) + this.MapProperty.GetHashCode();
                }
                if (this.MapOfMapProperty != null)
                {
                    hashCode = (hashCode * 59) + this.MapOfMapProperty.GetHashCode();
                }
                if (this.Anytype1 != null)
                {
                    hashCode = (hashCode * 59) + this.Anytype1.GetHashCode();
                }
                if (this.MapWithUndeclaredPropertiesAnytype1 != null)
                {
                    hashCode = (hashCode * 59) + this.MapWithUndeclaredPropertiesAnytype1.GetHashCode();
                }
                if (this.MapWithUndeclaredPropertiesAnytype2 != null)
                {
                    hashCode = (hashCode * 59) + this.MapWithUndeclaredPropertiesAnytype2.GetHashCode();
                }
                if (this.MapWithUndeclaredPropertiesAnytype3 != null)
                {
                    hashCode = (hashCode * 59) + this.MapWithUndeclaredPropertiesAnytype3.GetHashCode();
                }
                if (this.EmptyMap != null)
                {
                    hashCode = (hashCode * 59) + this.EmptyMap.GetHashCode();
                }
                if (this.MapWithUndeclaredPropertiesString != null)
                {
                    hashCode = (hashCode * 59) + this.MapWithUndeclaredPropertiesString.GetHashCode();
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
