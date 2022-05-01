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
    /// FileSchemaTestClass
    /// </summary>
    public partial class FileSchemaTestClass : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileSchemaTestClass" /> class.
        /// </summary>
        /// <param name="file">file</param>
        /// <param name="files">files</param>
        [JsonConstructor]
        public FileSchemaTestClass(File file, List<File> files)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (file == null)
                throw new ArgumentNullException("file is a required property for FileSchemaTestClass and cannot be null.");

            if (files == null)
                throw new ArgumentNullException("files is a required property for FileSchemaTestClass and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            File = file;
            Files = files;
        }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [JsonPropertyName("file")]
        public File File { get; set; }

        /// <summary>
        /// Gets or Sets Files
        /// </summary>
        [JsonPropertyName("files")]
        public List<File> Files { get; set; }

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
            sb.Append("class FileSchemaTestClass {\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
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
    /// A Json converter for type FileSchemaTestClass
    /// </summary>
    public class FileSchemaTestClassJsonConverter : JsonConverter<FileSchemaTestClass>
    {
        /// <summary>
        /// Returns a boolean if the type is compatible with this converter.
        /// </summary>
        /// <param name="typeToConvert"></param>
        /// <returns></returns>
        public override bool CanConvert(Type typeToConvert) => typeof(FileSchemaTestClass).IsAssignableFrom(typeToConvert);

        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override FileSchemaTestClass Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject && reader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            File file = default;
            List<File> files = default;

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
                        case "file":
                            Utf8JsonReader fileReader = reader;
                            file = JsonSerializer.Deserialize<File>(ref reader, options);
                            break;
                        case "files":
                            Utf8JsonReader filesReader = reader;
                            files = JsonSerializer.Deserialize<List<File>>(ref reader, options);
                            break;
                    }
                }
            }

            return new FileSchemaTestClass(file, files);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="fileSchemaTestClass"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, FileSchemaTestClass fileSchemaTestClass, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, fileSchemaTestClass);
        }
    }
}
