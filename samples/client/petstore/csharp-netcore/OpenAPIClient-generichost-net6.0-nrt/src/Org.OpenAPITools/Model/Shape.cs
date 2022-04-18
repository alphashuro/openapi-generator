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
    /// Shape
    /// </summary>
    public partial class Shape : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Shape" /> class.
        /// </summary>
        /// <param name="triangle"></param>
        /// <param name="quadrilateralType">quadrilateralType</param>
        [JsonConstructor]
        public Shape(Triangle triangle, string quadrilateralType)
        {
            #pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            #pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (quadrilateralType == null)
                throw new ArgumentNullException(nameof(QuadrilateralType));

            #pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            #pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            Triangle = triangle;
            QuadrilateralType = quadrilateralType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Shape" /> class.
        /// </summary>
        /// <param name="quadrilateral"></param>
        /// <param name="quadrilateralType">quadrilateralType</param>
        [JsonConstructor]
        public Shape(Quadrilateral quadrilateral, string quadrilateralType)
        {
            #pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            #pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (quadrilateralType == null)
                throw new ArgumentNullException(nameof(QuadrilateralType));

            #pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            #pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            Quadrilateral = quadrilateral;
            QuadrilateralType = quadrilateralType;
        }

        /// <summary>
        /// Gets or Sets Triangle
        /// </summary>
        public Triangle? Triangle { get; set; }

        /// <summary>
        /// Gets or Sets Quadrilateral
        /// </summary>
        public Quadrilateral? Quadrilateral { get; set; }

        /// <summary>
        /// Gets or Sets QuadrilateralType
        /// </summary>
        [JsonPropertyName("quadrilateralType")]
        public string QuadrilateralType { get; set; }

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
            sb.Append("class Shape {\n");
            sb.Append("  QuadrilateralType: ").Append(QuadrilateralType).Append("\n");
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
    /// A Json converter for type Shape
    /// </summary>
    public class ShapeJsonConverter : JsonConverter<Shape>
    {
        /// <summary>
        /// Returns a boolean if the type is compatible with this converter.
        /// </summary>
        /// <param name="typeToConvert"></param>
        /// <returns></returns>
        public override bool CanConvert(Type typeToConvert) => typeof(Shape).IsAssignableFrom(typeToConvert);

        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Shape Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException();

            Utf8JsonReader triangleReader = reader;
            bool triangleDeserialized = Client.ClientUtils.TryDeserialize<Triangle>(ref triangleReader, options, out Triangle? triangle);

            Utf8JsonReader quadrilateralReader = reader;
            bool quadrilateralDeserialized = Client.ClientUtils.TryDeserialize<Quadrilateral>(ref quadrilateralReader, options, out Quadrilateral? quadrilateral);

            string quadrilateralType = default;

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
                        case "quadrilateralType":
                            quadrilateralType = reader.GetString();
                            break;
                    }
                }
            }

            if (triangleDeserialized)
                return new Shape(triangle, quadrilateralType);

            if (quadrilateralDeserialized)
                return new Shape(quadrilateral, quadrilateralType);

            throw new JsonException();
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="shape"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Shape shape, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, shape);
        }
    }
}
