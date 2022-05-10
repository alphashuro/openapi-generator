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
    /// EquilateralTriangle
    /// </summary>
    public partial class EquilateralTriangle : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EquilateralTriangle" /> class.
        /// </summary>
        /// <param name="shapeInterface"></param>
        /// <param name="triangleInterface"></param>
        [JsonConstructor]
        internal EquilateralTriangle(ShapeInterface shapeInterface, TriangleInterface triangleInterface)
        {
            ShapeInterface = shapeInterface;
            TriangleInterface = triangleInterface;
        }

        /// <summary>
        /// Gets or Sets ShapeInterface
        /// </summary>
        public ShapeInterface ShapeInterface { get; set; }

        /// <summary>
        /// Gets or Sets TriangleInterface
        /// </summary>
        public TriangleInterface TriangleInterface { get; set; }

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
            sb.Append("class EquilateralTriangle {\n");
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
    /// A Json converter for type EquilateralTriangle
    /// </summary>
    public class EquilateralTriangleJsonConverter : JsonConverter<EquilateralTriangle>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override EquilateralTriangle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject && reader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = reader.TokenType;

            Utf8JsonReader shapeInterfaceReader = reader;
            bool shapeInterfaceDeserialized = Client.ClientUtils.TryDeserialize<ShapeInterface>(ref shapeInterfaceReader, options, out ShapeInterface shapeInterface);

            Utf8JsonReader triangleInterfaceReader = reader;
            bool triangleInterfaceDeserialized = Client.ClientUtils.TryDeserialize<TriangleInterface>(ref triangleInterfaceReader, options, out TriangleInterface triangleInterface);


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
                    }
                }
            }

            return new EquilateralTriangle(shapeInterface, triangleInterface);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="equilateralTriangle"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, EquilateralTriangle equilateralTriangle, JsonSerializerOptions options)
        {
            writer.WriteStartObject();


            writer.WriteEndObject();
        }
    }
}
