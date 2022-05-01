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
    /// Model for testing model name same as property name
    /// </summary>
    public partial class Name : IEquatable<Name?>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Name" /> class.
        /// </summary>
        /// <param name="nameProperty">nameProperty</param>
        /// <param name="property">property</param>
        /// <param name="snakeCase">snakeCase</param>
        /// <param name="_123number">_123number</param>
        [JsonConstructor]
        public Name(int nameProperty, string property, int snakeCase, int _123number)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (nameProperty == null)
                throw new ArgumentNullException("nameProperty is a required property for Name and cannot be null.");

            if (snakeCase == null)
                throw new ArgumentNullException("snakeCase is a required property for Name and cannot be null.");

            if (property == null)
                throw new ArgumentNullException("property is a required property for Name and cannot be null.");

            if (_123number == null)
                throw new ArgumentNullException("_123number is a required property for Name and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            NameProperty = nameProperty;
            Property = property;
            SnakeCase = snakeCase;
            _123Number = _123number;
        }

        /// <summary>
        /// Gets or Sets NameProperty
        /// </summary>
        [JsonPropertyName("name")]
        public int NameProperty { get; set; }

        /// <summary>
        /// Gets or Sets Property
        /// </summary>
        [JsonPropertyName("property")]
        public string Property { get; set; }

        /// <summary>
        /// Gets or Sets SnakeCase
        /// </summary>
        [JsonPropertyName("snake_case")]
        public int SnakeCase { get; }

        /// <summary>
        /// Gets or Sets _123Number
        /// </summary>
        [JsonPropertyName("123Number")]
        public int _123Number { get; }

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
            sb.Append("class Name {\n");
            sb.Append("  NameProperty: ").Append(NameProperty).Append("\n");
            sb.Append("  Property: ").Append(Property).Append("\n");
            sb.Append("  SnakeCase: ").Append(SnakeCase).Append("\n");
            sb.Append("  _123Number: ").Append(_123Number).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as Name).AreEqual;
        }

        /// <summary>
        /// Returns true if Name instances are equal
        /// </summary>
        /// <param name="input">Instance of Name to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Name? input)
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
                hashCode = (hashCode * 59) + SnakeCase.GetHashCode();
                hashCode = (hashCode * 59) + _123Number.GetHashCode();
                hashCode = (hashCode * 59) + AdditionalProperties.GetHashCode();

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

    /// <summary>
    /// A Json converter for type Name
    /// </summary>
    public class NameJsonConverter : JsonConverter<Name>
    {
        /// <summary>
        /// Returns a boolean if the type is compatible with this converter.
        /// </summary>
        /// <param name="typeToConvert"></param>
        /// <returns></returns>
        public override bool CanConvert(Type typeToConvert) => typeof(Name).IsAssignableFrom(typeToConvert);

        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Name Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject && reader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            int nameProperty = default;
            string property = default;
            int snakeCase = default;
            int _123number = default;

            while (reader.Read())
            {
                if ((reader.TokenType == JsonTokenType.EndObject || reader.TokenType == JsonTokenType.EndArray) && currentDepth == reader.CurrentDepth)
                    break;

                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    string? propertyName = reader.GetString();
                    reader.Read();

                    switch (propertyName)
                    {
                        case "name":
                            nameProperty = reader.GetInt32();
                            break;
                        case "property":
                            property = reader.GetString();
                            break;
                        case "snake_case":
                            snakeCase = reader.GetInt32();
                            break;
                        case "123Number":
                            _123number = reader.GetInt32();
                            break;
                    }
                }
            }

            return new Name(nameProperty, property, snakeCase, _123number);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="name"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Name name, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, name);
        }
    }
}
