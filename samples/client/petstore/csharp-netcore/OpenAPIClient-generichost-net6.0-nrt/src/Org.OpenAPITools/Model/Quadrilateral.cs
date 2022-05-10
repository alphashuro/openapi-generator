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
    /// Quadrilateral
    /// </summary>
    public partial class Quadrilateral : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Quadrilateral" /> class.
        /// </summary>
        /// <param name="simpleQuadrilateral"></param>
        [JsonConstructor]
        internal Quadrilateral(SimpleQuadrilateral simpleQuadrilateral)
        {
            SimpleQuadrilateral = simpleQuadrilateral;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Quadrilateral" /> class.
        /// </summary>
        /// <param name="complexQuadrilateral"></param>
        [JsonConstructor]
        internal Quadrilateral(ComplexQuadrilateral complexQuadrilateral)
        {
            ComplexQuadrilateral = complexQuadrilateral;
        }

        /// <summary>
        /// Gets or Sets SimpleQuadrilateral
        /// </summary>
        public SimpleQuadrilateral? SimpleQuadrilateral { get; set; }

        /// <summary>
        /// Gets or Sets ComplexQuadrilateral
        /// </summary>
        public ComplexQuadrilateral? ComplexQuadrilateral { get; set; }

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
            sb.Append("class Quadrilateral {\n");
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
    /// A Json converter for type Quadrilateral
    /// </summary>
    public class QuadrilateralJsonConverter : JsonConverter<Quadrilateral>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Quadrilateral Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject && reader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = reader.TokenType;

            Utf8JsonReader simpleQuadrilateralReader = reader;
            bool simpleQuadrilateralDeserialized = Client.ClientUtils.TryDeserialize<SimpleQuadrilateral>(ref simpleQuadrilateralReader, options, out SimpleQuadrilateral? simpleQuadrilateral);

            Utf8JsonReader complexQuadrilateralReader = reader;
            bool complexQuadrilateralDeserialized = Client.ClientUtils.TryDeserialize<ComplexQuadrilateral>(ref complexQuadrilateralReader, options, out ComplexQuadrilateral? complexQuadrilateral);


            while (reader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && reader.TokenType == JsonTokenType.EndObject && currentDepth == reader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && reader.TokenType == JsonTokenType.EndArray && currentDepth == reader.CurrentDepth)
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

            if (simpleQuadrilateralDeserialized)
                return new Quadrilateral(simpleQuadrilateral);

            if (complexQuadrilateralDeserialized)
                return new Quadrilateral(complexQuadrilateral);

            throw new JsonException();
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="quadrilateral"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Quadrilateral quadrilateral, JsonSerializerOptions options)
        {
            writer.WriteStartObject();


            writer.WriteEndObject();
        }
    }
}
