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
    /// HasOnlyReadOnly
    /// </summary>
    public partial class HasOnlyReadOnly : IEquatable<HasOnlyReadOnly?>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HasOnlyReadOnly" /> class.
        /// </summary>
        /// <param name="bar">bar</param>
        /// <param name="foo">foo</param>
        [JsonConstructor]
        internal HasOnlyReadOnly(string bar, string foo)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (bar == null)
                throw new ArgumentNullException("bar is a required property for HasOnlyReadOnly and cannot be null.");

            if (foo == null)
                throw new ArgumentNullException("foo is a required property for HasOnlyReadOnly and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            Bar = bar;
            Foo = foo;
        }

        /// <summary>
        /// Gets or Sets Bar
        /// </summary>
        [JsonPropertyName("bar")]
        public string Bar { get; }

        /// <summary>
        /// Gets or Sets Foo
        /// </summary>
        [JsonPropertyName("foo")]
        public string Foo { get; }

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
            sb.Append("class HasOnlyReadOnly {\n");
            sb.Append("  Bar: ").Append(Bar).Append("\n");
            sb.Append("  Foo: ").Append(Foo).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as HasOnlyReadOnly).AreEqual;
        }

        /// <summary>
        /// Returns true if HasOnlyReadOnly instances are equal
        /// </summary>
        /// <param name="input">Instance of HasOnlyReadOnly to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HasOnlyReadOnly? input)
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
                hashCode = (hashCode * 59) + Bar.GetHashCode();
                hashCode = (hashCode * 59) + Foo.GetHashCode();
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
    /// A Json converter for type HasOnlyReadOnly
    /// </summary>
    public class HasOnlyReadOnlyJsonConverter : JsonConverter<HasOnlyReadOnly>
    {
        /// <summary>
        /// Returns a boolean if the type is compatible with this converter.
        /// </summary>
        /// <param name="typeToConvert"></param>
        /// <returns></returns>
        public override bool CanConvert(Type typeToConvert) => typeof(HasOnlyReadOnly).IsAssignableFrom(typeToConvert);

        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override HasOnlyReadOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject && reader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            string bar = default;
            string foo = default;

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
                        case "bar":
                            bar = reader.GetString();
                            break;
                        case "foo":
                            foo = reader.GetString();
                            break;
                    }
                }
            }

            return new HasOnlyReadOnly(bar, foo);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="hasOnlyReadOnly"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, HasOnlyReadOnly hasOnlyReadOnly, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, hasOnlyReadOnly);
        }
    }
}
