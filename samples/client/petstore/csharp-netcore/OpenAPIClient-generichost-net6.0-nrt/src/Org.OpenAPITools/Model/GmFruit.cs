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
    /// GmFruit
    /// </summary>
    public partial class GmFruit : IEquatable<GmFruit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GmFruit" /> class.
        /// </summary>
        /// <param name="apple">apple</param> anyOf
        /// <param name="banana">banana</param> anyOf
        /// <param name="color">color</param> allVars
        public GmFruit(Apple? apple, Banana? banana, string? color = default)
        {
            Apple = apple;
            Banana = banana;
            Color = color;
        }

        /// <summary>
        /// Gets or Sets gmFruit
        /// </summary>
        public Apple? Apple { get; set; }

        /// <summary>
        /// Gets or Sets gmFruit
        /// </summary>
        public Banana? Banana { get; set; }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [JsonPropertyName("color")]
        public string? Color { get; set; }
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
            sb.Append("class GmFruit {\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as GmFruit).AreEqual;
        }

        /// <summary>
        /// Returns true if GmFruit instances are equal
        /// </summary>
        /// <param name="input">Instance of GmFruit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GmFruit? input)
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
                if (this.Color != null)
                {
                    hashCode = (hashCode * 59) + this.Color.GetHashCode();
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

    /// <summary>
    /// A Json converter for type GmFruit
    /// </summary>
    public class GmFruitJsonConverter : JsonConverter<GmFruit>
    {
        /// <summary>
        /// Returns a boolean if the type is compatible with this converter.
        /// </summary>
        /// <param name="typeToConvert"></param>
        /// <returns></returns>
        public override bool CanConvert(Type typeToConvert) => typeof(GmFruit).IsAssignableFrom(typeToConvert);

        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GmFruit Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException();

            Utf8JsonReader appleReader = reader;
            Client.ClientUtils.TryDeserialize<Apple>(ref appleReader, options, out Apple? apple);

            Utf8JsonReader bananaReader = reader;
            Client.ClientUtils.TryDeserialize<Banana>(ref bananaReader, options, out Banana? banana);

            string? color = default;

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject && currentDepth == reader.CurrentDepth)
                    break;

                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    string? propertyName = reader.GetString();
                    reader.Read();

                    switch (propertyName)
                    {
                        case "color":
                            color = reader.GetString();
                            break;
                    }
                }
            }

            return new GmFruit(apple, banana, color);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="gmFruit"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GmFruit gmFruit, JsonSerializerOptions options) => throw new NotImplementedException();
    }
}
