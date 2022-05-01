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
    /// Dog
    /// </summary>
    public partial class Dog : Animal, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dog" /> class.
        /// </summary>
        /// <param name="dogAllOf"></param>
        /// <param name="className">className</param>
        /// <param name="color">color (default to &quot;red&quot;)</param>
        [JsonConstructor]
        internal Dog(DogAllOf dogAllOf, string className, string color = "red") : base(className, color)
        {
            DogAllOf = dogAllOf;
        }

        /// <summary>
        /// Gets or Sets DogAllOf
        /// </summary>
        public DogAllOf DogAllOf { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Dog {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type Dog
    /// </summary>
    public class DogJsonConverter : JsonConverter<Dog>
    {
        /// <summary>
        /// Returns a boolean if the type is compatible with this converter.
        /// </summary>
        /// <param name="typeToConvert"></param>
        /// <returns></returns>
        public override bool CanConvert(Type typeToConvert) => typeof(Dog).IsAssignableFrom(typeToConvert);

        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Dog Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject && reader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            Utf8JsonReader dogAllOfReader = reader;
            bool dogAllOfDeserialized = Client.ClientUtils.TryDeserialize<DogAllOf>(ref dogAllOfReader, options, out DogAllOf? dogAllOf);

            string className = default;
            string color = default;

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
                        case "className":
                            className = reader.GetString();
                            break;
                        case "color":
                            color = reader.GetString();
                            break;
                    }
                }
            }

            return new Dog(dogAllOf, className, color);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dog"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Dog dog, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, dog);
        }
    }
}
