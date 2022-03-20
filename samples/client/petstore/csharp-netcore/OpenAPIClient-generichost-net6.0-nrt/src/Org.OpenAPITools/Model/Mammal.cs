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
    /// Mammal
    /// </summary>
    public partial class Mammal : IEquatable<Mammal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mammal" /> class.
        /// </summary>
        /// <param name="whale"></param>
        public Mammal(Whale whale)
        {
            Whale = whale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mammal" /> class.
        /// </summary>
        /// <param name="zebra"></param>
        public Mammal(Zebra zebra)
        {
            Zebra = zebra;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mammal" /> class.
        /// </summary>
        /// <param name="pig"></param>
        public Mammal(Pig pig)
        {
            Pig = pig;
        }

        /// <summary>
        /// Gets or Sets Whale
        /// </summary>
        public Whale? Whale { get; set; }

        /// <summary>
        /// Gets or Sets Zebra
        /// </summary>
        public Zebra? Zebra { get; set; }

        /// <summary>
        /// Gets or Sets Pig
        /// </summary>
        public Pig? Pig { get; set; }

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
            sb.Append("class Mammal {\n");
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
            return OpenAPIClientUtils.compareLogic.Compare(this, input as Mammal).AreEqual;
        }

        /// <summary>
        /// Returns true if Mammal instances are equal
        /// </summary>
        /// <param name="input">Instance of Mammal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Mammal? input)
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type Mammal
    /// </summary>
    public class MammalJsonConverter : JsonConverter<Mammal>
    {
        /// <summary>
        /// Returns a boolean if the type is compatible with this converter.
        /// </summary>
        /// <param name="typeToConvert"></param>
        /// <returns></returns>
        public override bool CanConvert(Type typeToConvert) => typeof(Mammal).IsAssignableFrom(typeToConvert);

        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Mammal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException();

            Utf8JsonReader whaleReader = reader;
            bool whaleDeserialized = Client.ClientUtils.TryDeserialize<Whale>(ref whaleReader, options, out Whale? whale);

            Utf8JsonReader zebraReader = reader;
            bool zebraDeserialized = Client.ClientUtils.TryDeserialize<Zebra>(ref zebraReader, options, out Zebra? zebra);

            Utf8JsonReader pigReader = reader;
            bool pigDeserialized = Client.ClientUtils.TryDeserialize<Pig>(ref pigReader, options, out Pig? pig);


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
                    }
                }
            }

            if (whaleDeserialized)
                return new Mammal(whale);

            if (zebraDeserialized)
                return new Mammal(zebra);

            if (pigDeserialized)
                return new Mammal(pig);

            throw new JsonException();
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="mammal"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Mammal mammal, JsonSerializerOptions options) => throw new NotImplementedException();
    }
}
