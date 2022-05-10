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
    /// Apple
    /// </summary>
    public partial class Apple : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Apple" /> class.
        /// </summary>
        /// <param name="cultivar">cultivar</param>
        /// <param name="origin">origin</param>
        [JsonConstructor]
        public Apple(string cultivar, string origin)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (cultivar == null)
                throw new ArgumentNullException("cultivar is a required property for Apple and cannot be null.");

            if (origin == null)
                throw new ArgumentNullException("origin is a required property for Apple and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            Cultivar = cultivar;
            Origin = origin;
        }

        /// <summary>
        /// Gets or Sets Cultivar
        /// </summary>
        [JsonPropertyName("cultivar")]
        public string Cultivar { get; set; }

        /// <summary>
        /// Gets or Sets Origin
        /// </summary>
        [JsonPropertyName("origin")]
        public string Origin { get; set; }

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
            sb.Append("class Apple {\n");
            sb.Append("  Cultivar: ").Append(Cultivar).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
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
            // Cultivar (string) pattern
            Regex regexCultivar = new Regex(@"^[a-zA-Z\\s]*$", RegexOptions.CultureInvariant);
            if (false == regexCultivar.Match(this.Cultivar).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cultivar, must match a pattern of " + regexCultivar, new [] { "Cultivar" });
            }

            // Origin (string) pattern
            Regex regexOrigin = new Regex(@"^[A-Z\\s]*$", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);
            if (false == regexOrigin.Match(this.Origin).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Origin, must match a pattern of " + regexOrigin, new [] { "Origin" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type Apple
    /// </summary>
    public class AppleJsonConverter : JsonConverter<Apple>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Apple Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject && reader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = reader.TokenType;

            string cultivar = default;
            string origin = default;

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
                        case "cultivar":
                            cultivar = reader.GetString();
                            break;
                        case "origin":
                            origin = reader.GetString();
                            break;
                    }
                }
            }

            return new Apple(cultivar, origin);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="apple"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Apple apple, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            writer.WriteString("cultivar", apple.Cultivar);
            writer.WriteString("origin", apple.Origin);

            writer.WriteEndObject();
        }
    }
}
