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
    public partial class AdditionalPropertiesClass : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalPropertiesClass" /> class.
        /// </summary>
        /// <param name="emptyMap">an object with no declared properties and no undeclared properties, hence it&#39;s an empty map.</param>
        /// <param name="mapOfMapProperty">mapOfMapProperty</param>
        /// <param name="mapProperty">mapProperty</param>
        /// <param name="mapWithUndeclaredPropertiesAnytype1">mapWithUndeclaredPropertiesAnytype1</param>
        /// <param name="mapWithUndeclaredPropertiesAnytype2">mapWithUndeclaredPropertiesAnytype2</param>
        /// <param name="mapWithUndeclaredPropertiesAnytype3">mapWithUndeclaredPropertiesAnytype3</param>
        /// <param name="mapWithUndeclaredPropertiesString">mapWithUndeclaredPropertiesString</param>
        /// <param name="anytype1">anytype1</param>
        [JsonConstructor]
        public AdditionalPropertiesClass(Object emptyMap, Dictionary<string, Dictionary<string, string>> mapOfMapProperty, Dictionary<string, string> mapProperty, Object mapWithUndeclaredPropertiesAnytype1, Object mapWithUndeclaredPropertiesAnytype2, Dictionary<string, Object> mapWithUndeclaredPropertiesAnytype3, Dictionary<string, string> mapWithUndeclaredPropertiesString, Object anytype1 = default)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (mapProperty == null)
                throw new ArgumentNullException("mapProperty is a required property for AdditionalPropertiesClass and cannot be null.");

            if (mapOfMapProperty == null)
                throw new ArgumentNullException("mapOfMapProperty is a required property for AdditionalPropertiesClass and cannot be null.");

            if (mapWithUndeclaredPropertiesAnytype1 == null)
                throw new ArgumentNullException("mapWithUndeclaredPropertiesAnytype1 is a required property for AdditionalPropertiesClass and cannot be null.");

            if (mapWithUndeclaredPropertiesAnytype2 == null)
                throw new ArgumentNullException("mapWithUndeclaredPropertiesAnytype2 is a required property for AdditionalPropertiesClass and cannot be null.");

            if (mapWithUndeclaredPropertiesAnytype3 == null)
                throw new ArgumentNullException("mapWithUndeclaredPropertiesAnytype3 is a required property for AdditionalPropertiesClass and cannot be null.");

            if (emptyMap == null)
                throw new ArgumentNullException("emptyMap is a required property for AdditionalPropertiesClass and cannot be null.");

            if (mapWithUndeclaredPropertiesString == null)
                throw new ArgumentNullException("mapWithUndeclaredPropertiesString is a required property for AdditionalPropertiesClass and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            EmptyMap = emptyMap;
            MapOfMapProperty = mapOfMapProperty;
            MapProperty = mapProperty;
            MapWithUndeclaredPropertiesAnytype1 = mapWithUndeclaredPropertiesAnytype1;
            MapWithUndeclaredPropertiesAnytype2 = mapWithUndeclaredPropertiesAnytype2;
            MapWithUndeclaredPropertiesAnytype3 = mapWithUndeclaredPropertiesAnytype3;
            MapWithUndeclaredPropertiesString = mapWithUndeclaredPropertiesString;
            Anytype1 = anytype1;
        }

        /// <summary>
        /// an object with no declared properties and no undeclared properties, hence it&#39;s an empty map.
        /// </summary>
        /// <value>an object with no declared properties and no undeclared properties, hence it&#39;s an empty map.</value>
        [JsonPropertyName("empty_map")]
        public Object EmptyMap { get; set; }

        /// <summary>
        /// Gets or Sets MapOfMapProperty
        /// </summary>
        [JsonPropertyName("map_of_map_property")]
        public Dictionary<string, Dictionary<string, string>> MapOfMapProperty { get; set; }

        /// <summary>
        /// Gets or Sets MapProperty
        /// </summary>
        [JsonPropertyName("map_property")]
        public Dictionary<string, string> MapProperty { get; set; }

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
        /// Gets or Sets MapWithUndeclaredPropertiesString
        /// </summary>
        [JsonPropertyName("map_with_undeclared_properties_string")]
        public Dictionary<string, string> MapWithUndeclaredPropertiesString { get; set; }

        /// <summary>
        /// Gets or Sets Anytype1
        /// </summary>
        [JsonPropertyName("anytype_1")]
        public Object Anytype1 { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdditionalPropertiesClass {\n");
            sb.Append("  EmptyMap: ").Append(EmptyMap).Append("\n");
            sb.Append("  MapOfMapProperty: ").Append(MapOfMapProperty).Append("\n");
            sb.Append("  MapProperty: ").Append(MapProperty).Append("\n");
            sb.Append("  MapWithUndeclaredPropertiesAnytype1: ").Append(MapWithUndeclaredPropertiesAnytype1).Append("\n");
            sb.Append("  MapWithUndeclaredPropertiesAnytype2: ").Append(MapWithUndeclaredPropertiesAnytype2).Append("\n");
            sb.Append("  MapWithUndeclaredPropertiesAnytype3: ").Append(MapWithUndeclaredPropertiesAnytype3).Append("\n");
            sb.Append("  MapWithUndeclaredPropertiesString: ").Append(MapWithUndeclaredPropertiesString).Append("\n");
            sb.Append("  Anytype1: ").Append(Anytype1).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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

    /// <summary>
    /// A Json converter for type AdditionalPropertiesClass
    /// </summary>
    public class AdditionalPropertiesClassJsonConverter : JsonConverter<AdditionalPropertiesClass>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AdditionalPropertiesClass Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject && reader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = reader.TokenType;

            Object emptyMap = default;
            Dictionary<string, Dictionary<string, string>> mapOfMapProperty = default;
            Dictionary<string, string> mapProperty = default;
            Object mapWithUndeclaredPropertiesAnytype1 = default;
            Object mapWithUndeclaredPropertiesAnytype2 = default;
            Dictionary<string, Object> mapWithUndeclaredPropertiesAnytype3 = default;
            Dictionary<string, string> mapWithUndeclaredPropertiesString = default;
            Object anytype1 = default;

            while (reader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && reader.TokenType == JsonTokenType.EndObject && currentDepth == reader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && reader.TokenType == JsonTokenType.EndArray && currentDepth == reader.CurrentDepth)
                    break;

                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    string propertyName = reader.GetString();
                    reader.Read();

                    switch (propertyName)
                    {
                        case "empty_map":
                            Utf8JsonReader emptyMapReader = reader;
                            emptyMap = JsonSerializer.Deserialize<Object>(ref reader, options);
                            break;
                        case "map_of_map_property":
                            Utf8JsonReader mapOfMapPropertyReader = reader;
                            mapOfMapProperty = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(ref reader, options);
                            break;
                        case "map_property":
                            Utf8JsonReader mapPropertyReader = reader;
                            mapProperty = JsonSerializer.Deserialize<Dictionary<string, string>>(ref reader, options);
                            break;
                        case "map_with_undeclared_properties_anytype_1":
                            Utf8JsonReader mapWithUndeclaredPropertiesAnytype1Reader = reader;
                            mapWithUndeclaredPropertiesAnytype1 = JsonSerializer.Deserialize<Object>(ref reader, options);
                            break;
                        case "map_with_undeclared_properties_anytype_2":
                            Utf8JsonReader mapWithUndeclaredPropertiesAnytype2Reader = reader;
                            mapWithUndeclaredPropertiesAnytype2 = JsonSerializer.Deserialize<Object>(ref reader, options);
                            break;
                        case "map_with_undeclared_properties_anytype_3":
                            Utf8JsonReader mapWithUndeclaredPropertiesAnytype3Reader = reader;
                            mapWithUndeclaredPropertiesAnytype3 = JsonSerializer.Deserialize<Dictionary<string, Object>>(ref reader, options);
                            break;
                        case "map_with_undeclared_properties_string":
                            Utf8JsonReader mapWithUndeclaredPropertiesStringReader = reader;
                            mapWithUndeclaredPropertiesString = JsonSerializer.Deserialize<Dictionary<string, string>>(ref reader, options);
                            break;
                        case "anytype_1":
                            Utf8JsonReader anytype1Reader = reader;
                            anytype1 = JsonSerializer.Deserialize<Object>(ref reader, options);
                            break;
                    }
                }
            }

            return new AdditionalPropertiesClass(emptyMap, mapOfMapProperty, mapProperty, mapWithUndeclaredPropertiesAnytype1, mapWithUndeclaredPropertiesAnytype2, mapWithUndeclaredPropertiesAnytype3, mapWithUndeclaredPropertiesString, anytype1);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="additionalPropertiesClass"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AdditionalPropertiesClass additionalPropertiesClass, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("empty_map");
            JsonSerializer.Serialize(writer, additionalPropertiesClass.EmptyMap, options);
            writer.WritePropertyName("map_of_map_property");
            JsonSerializer.Serialize(writer, additionalPropertiesClass.MapOfMapProperty, options);
            writer.WritePropertyName("map_property");
            JsonSerializer.Serialize(writer, additionalPropertiesClass.MapProperty, options);
            writer.WritePropertyName("map_with_undeclared_properties_anytype_1");
            JsonSerializer.Serialize(writer, additionalPropertiesClass.MapWithUndeclaredPropertiesAnytype1, options);
            writer.WritePropertyName("map_with_undeclared_properties_anytype_2");
            JsonSerializer.Serialize(writer, additionalPropertiesClass.MapWithUndeclaredPropertiesAnytype2, options);
            writer.WritePropertyName("map_with_undeclared_properties_anytype_3");
            JsonSerializer.Serialize(writer, additionalPropertiesClass.MapWithUndeclaredPropertiesAnytype3, options);
            writer.WritePropertyName("map_with_undeclared_properties_string");
            JsonSerializer.Serialize(writer, additionalPropertiesClass.MapWithUndeclaredPropertiesString, options);
            writer.WritePropertyName("anytype_1");
            JsonSerializer.Serialize(writer, additionalPropertiesClass.Anytype1, options);

            writer.WriteEndObject();
        }
    }
}
