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
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// EnumArrays
    /// </summary>
    public partial class EnumArrays : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumArrays" /> class.
        /// </summary>
        /// <param name="arrayEnum">arrayEnum</param>
        /// <param name="justSymbol">justSymbol</param>
        [JsonConstructor]
        public EnumArrays(List<EnumArrays.ArrayEnumEnum> arrayEnum, JustSymbolEnum justSymbol)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (justSymbol == null)
                throw new ArgumentNullException("justSymbol is a required property for EnumArrays and cannot be null.");

            if (arrayEnum == null)
                throw new ArgumentNullException("arrayEnum is a required property for EnumArrays and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            ArrayEnum = arrayEnum;
            JustSymbol = justSymbol;
        }

        /// <summary>
        /// Defines ArrayEnum
        /// </summary>
        public enum ArrayEnumEnum
        {
            /// <summary>
            /// Enum Fish for value: fish
            /// </summary>
            Fish = 1,

            /// <summary>
            /// Enum Crab for value: crab
            /// </summary>
            Crab = 2
        }

        /// <summary>
        /// Returns a ArrayEnumEnum
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ArrayEnumEnum ArrayEnumEnumFromString(string value)
        {
            if (value == "fish")
                return ArrayEnumEnum.Fish;

            if (value == "crab")
                return ArrayEnumEnum.Crab;

            throw new NotImplementedException($"Could not convert value to type ArrayEnumEnum: '{value}'");
        }

        /// <summary>
        /// Returns equivalent json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ArrayEnumEnumToJsonValue(ArrayEnumEnum value)
        {
            if (value == ArrayEnumEnum.Fish)
                return "fish";

            if (value == ArrayEnumEnum.Crab)
                return "crab";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Defines JustSymbol
        /// </summary>
        public enum JustSymbolEnum
        {
            /// <summary>
            /// Enum GreaterThanOrEqualTo for value: &gt;&#x3D;
            /// </summary>
            GreaterThanOrEqualTo = 1,

            /// <summary>
            /// Enum Dollar for value: $
            /// </summary>
            Dollar = 2
        }

        /// <summary>
        /// Returns a JustSymbolEnum
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static JustSymbolEnum JustSymbolEnumFromString(string value)
        {
            if (value == ">=")
                return JustSymbolEnum.GreaterThanOrEqualTo;

            if (value == "$")
                return JustSymbolEnum.Dollar;

            throw new NotImplementedException($"Could not convert value to type JustSymbolEnum: '{value}'");
        }

        /// <summary>
        /// Returns equivalent json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string JustSymbolEnumToJsonValue(JustSymbolEnum value)
        {
            if (value == JustSymbolEnum.GreaterThanOrEqualTo)
                return "&gt;&#x3D;";

            if (value == JustSymbolEnum.Dollar)
                return "$";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets JustSymbol
        /// </summary>
        [JsonPropertyName("just_symbol")]
        public JustSymbolEnum JustSymbol { get; set; }

        /// <summary>
        /// Gets or Sets ArrayEnum
        /// </summary>
        [JsonPropertyName("array_enum")]
        public List<EnumArrays.ArrayEnumEnum> ArrayEnum { get; set; }

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
            sb.Append("class EnumArrays {\n");
            sb.Append("  ArrayEnum: ").Append(ArrayEnum).Append("\n");
            sb.Append("  JustSymbol: ").Append(JustSymbol).Append("\n");
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
    /// A Json converter for type EnumArrays
    /// </summary>
    public class EnumArraysJsonConverter : JsonConverter<EnumArrays>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EnumArrays Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject && reader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = reader.TokenType;

            List<EnumArrays.ArrayEnumEnum> arrayEnum = default;
            EnumArrays.JustSymbolEnum justSymbol = default;

            while (reader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && reader.TokenType == JsonTokenType.EndObject && currentDepth == reader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && reader.TokenType == JsonTokenType.EndArray && currentDepth == reader.CurrentDepth)
                    break;

                if (reader.TokenType == JsonTokenType.PropertyName && currentDepth == reader.CurrentDepth - 1)
                {
                    string? propertyName = reader.GetString();
                    reader.Read();

                    switch (propertyName)
                    {
                        case "array_enum":
                            arrayEnum = JsonSerializer.Deserialize<List<EnumArrays.ArrayEnumEnum>>(ref reader, options);
                            break;
                        case "just_symbol":
                            string justSymbolRawValue = reader.GetString();
                            justSymbol = EnumArrays.JustSymbolEnumFromString(justSymbolRawValue);
                            break;
                        default:
                            break;
                    }
                }
            }

            return new EnumArrays(arrayEnum, justSymbol);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="enumArrays"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EnumArrays enumArrays, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("array_enum");
            JsonSerializer.Serialize(writer, enumArrays.ArrayEnum, options);
            var justSymbolRawValue = EnumArrays.JustSymbolEnumToJsonValue(enumArrays.JustSymbol);
            if (justSymbolRawValue != null)
                writer.WriteString("just_symbol", justSymbolRawValue);
            else
                writer.WriteNull("just_symbol");

            writer.WriteEndObject();
        }
    }
}
