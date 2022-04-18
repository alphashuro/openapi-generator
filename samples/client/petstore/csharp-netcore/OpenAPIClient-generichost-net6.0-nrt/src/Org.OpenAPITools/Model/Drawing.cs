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
    /// Drawing
    /// </summary>
    public partial class Drawing : Dictionary<String, Fruit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Drawing" /> class.
        /// </summary>
        /// <param name="mainShape">mainShape</param>
        /// <param name="shapeOrNull">shapeOrNull</param>
        /// <param name="shapes">shapes</param>
        /// <param name="nullableShape">nullableShape</param>
        [JsonConstructor]
        public Drawing(Shape mainShape, ShapeOrNull shapeOrNull, List<Shape> shapes, NullableShape? nullableShape = default) : base()
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (mainShape == null)
                throw new ArgumentNullException("mainShape is a required property for Drawing and cannot be null.");

            if (shapeOrNull == null)
                throw new ArgumentNullException("shapeOrNull is a required property for Drawing and cannot be null.");

            if (shapes == null)
                throw new ArgumentNullException("shapes is a required property for Drawing and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            MainShape = mainShape;
            ShapeOrNull = shapeOrNull;
            Shapes = shapes;
            NullableShape = nullableShape;
        }

        /// <summary>
        /// Gets or Sets MainShape
        /// </summary>
        [JsonPropertyName("mainShape")]
        public Shape MainShape { get; set; }

        /// <summary>
        /// Gets or Sets ShapeOrNull
        /// </summary>
        [JsonPropertyName("shapeOrNull")]
        public ShapeOrNull ShapeOrNull { get; set; }

        /// <summary>
        /// Gets or Sets Shapes
        /// </summary>
        [JsonPropertyName("shapes")]
        public List<Shape> Shapes { get; set; }

        /// <summary>
        /// Gets or Sets NullableShape
        /// </summary>
        [JsonPropertyName("nullableShape")]
        public NullableShape? NullableShape { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Drawing {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  MainShape: ").Append(MainShape).Append("\n");
            sb.Append("  ShapeOrNull: ").Append(ShapeOrNull).Append("\n");
            sb.Append("  Shapes: ").Append(Shapes).Append("\n");
            sb.Append("  NullableShape: ").Append(NullableShape).Append("\n");
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
    /// A Json converter for type Drawing
    /// </summary>
    public class DrawingJsonConverter : JsonConverter<Drawing>
    {
        /// <summary>
        /// Returns a boolean if the type is compatible with this converter.
        /// </summary>
        /// <param name="typeToConvert"></param>
        /// <returns></returns>
        public override bool CanConvert(Type typeToConvert) => typeof(Drawing).IsAssignableFrom(typeToConvert);

        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Drawing Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException();

            Shape mainShape = default;
            ShapeOrNull shapeOrNull = default;
            List<Shape> shapes = default;
            NullableShape nullableShape = default;

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
                        case "mainShape":
                            Utf8JsonReader mainShapeReader = reader;
                            mainShape = JsonSerializer.Deserialize<Shape>(ref reader, options);
                            break;
                        case "shapeOrNull":
                            Utf8JsonReader shapeOrNullReader = reader;
                            shapeOrNull = JsonSerializer.Deserialize<ShapeOrNull>(ref reader, options);
                            break;
                        case "shapes":
                            Utf8JsonReader shapesReader = reader;
                            shapes = JsonSerializer.Deserialize<List<Shape>>(ref reader, options);
                            break;
                        case "nullableShape":
                            Utf8JsonReader nullableShapeReader = reader;
                            nullableShape = JsonSerializer.Deserialize<NullableShape>(ref reader, options);
                            break;
                    }
                }
            }

            return new Drawing(mainShape, shapeOrNull, shapes, nullableShape);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="drawing"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Drawing drawing, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, drawing);
        }
    }
}
