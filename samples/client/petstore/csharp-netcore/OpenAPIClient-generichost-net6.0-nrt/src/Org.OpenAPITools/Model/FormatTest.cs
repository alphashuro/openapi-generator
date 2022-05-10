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
    /// FormatTest
    /// </summary>
    public partial class FormatTest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormatTest" /> class.
        /// </summary>
        /// <param name="binary">binary</param>
        /// <param name="_byte">_byte</param>
        /// <param name="date">date</param>
        /// <param name="dateTime">dateTime</param>
        /// <param name="_decimal">_decimal</param>
        /// <param name="_double">_double</param>
        /// <param name="_float">_float</param>
        /// <param name="int32">int32</param>
        /// <param name="int64">int64</param>
        /// <param name="integer">integer</param>
        /// <param name="number">number</param>
        /// <param name="password">password</param>
        /// <param name="patternWithDigits">A string that is a 10 digit number. Can have leading zeros.</param>
        /// <param name="patternWithDigitsAndDelimiter">A string starting with &#39;image_&#39; (case insensitive) and one to three digits following i.e. Image_01.</param>
        /// <param name="_string">_string</param>
        /// <param name="uuid">uuid</param>
        [JsonConstructor]
        public FormatTest(System.IO.Stream binary, byte[] _byte, DateTime date, DateTime dateTime, decimal _decimal, double _double, float _float, int int32, long int64, int integer, decimal number, string password, string patternWithDigits, string patternWithDigitsAndDelimiter, string _string, Guid uuid)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (integer == null)
                throw new ArgumentNullException("integer is a required property for FormatTest and cannot be null.");

            if (int32 == null)
                throw new ArgumentNullException("int32 is a required property for FormatTest and cannot be null.");

            if (int64 == null)
                throw new ArgumentNullException("int64 is a required property for FormatTest and cannot be null.");

            if (number == null)
                throw new ArgumentNullException("number is a required property for FormatTest and cannot be null.");

            if (_float == null)
                throw new ArgumentNullException("_float is a required property for FormatTest and cannot be null.");

            if (_double == null)
                throw new ArgumentNullException("_double is a required property for FormatTest and cannot be null.");

            if (_decimal == null)
                throw new ArgumentNullException("_decimal is a required property for FormatTest and cannot be null.");

            if (_string == null)
                throw new ArgumentNullException("_string is a required property for FormatTest and cannot be null.");

            if (_byte == null)
                throw new ArgumentNullException("_byte is a required property for FormatTest and cannot be null.");

            if (binary == null)
                throw new ArgumentNullException("binary is a required property for FormatTest and cannot be null.");

            if (date == null)
                throw new ArgumentNullException("date is a required property for FormatTest and cannot be null.");

            if (dateTime == null)
                throw new ArgumentNullException("dateTime is a required property for FormatTest and cannot be null.");

            if (uuid == null)
                throw new ArgumentNullException("uuid is a required property for FormatTest and cannot be null.");

            if (password == null)
                throw new ArgumentNullException("password is a required property for FormatTest and cannot be null.");

            if (patternWithDigits == null)
                throw new ArgumentNullException("patternWithDigits is a required property for FormatTest and cannot be null.");

            if (patternWithDigitsAndDelimiter == null)
                throw new ArgumentNullException("patternWithDigitsAndDelimiter is a required property for FormatTest and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            Binary = binary;
            Byte = _byte;
            Date = date;
            DateTime = dateTime;
            Decimal = _decimal;
            Double = _double;
            Float = _float;
            Int32 = int32;
            Int64 = int64;
            Integer = integer;
            Number = number;
            Password = password;
            PatternWithDigits = patternWithDigits;
            PatternWithDigitsAndDelimiter = patternWithDigitsAndDelimiter;
            String = _string;
            Uuid = uuid;
        }

        /// <summary>
        /// Gets or Sets Binary
        /// </summary>
        [JsonPropertyName("binary")]
        public System.IO.Stream Binary { get; set; }

        /// <summary>
        /// Gets or Sets Byte
        /// </summary>
        [JsonPropertyName("byte")]
        public byte[] Byte { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or Sets DateTime
        /// </summary>
        [JsonPropertyName("dateTime")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Gets or Sets Decimal
        /// </summary>
        [JsonPropertyName("decimal")]
        public decimal Decimal { get; set; }

        /// <summary>
        /// Gets or Sets Double
        /// </summary>
        [JsonPropertyName("double")]
        public double Double { get; set; }

        /// <summary>
        /// Gets or Sets Float
        /// </summary>
        [JsonPropertyName("float")]
        public float Float { get; set; }

        /// <summary>
        /// Gets or Sets Int32
        /// </summary>
        [JsonPropertyName("int32")]
        public int Int32 { get; set; }

        /// <summary>
        /// Gets or Sets Int64
        /// </summary>
        [JsonPropertyName("int64")]
        public long Int64 { get; set; }

        /// <summary>
        /// Gets or Sets Integer
        /// </summary>
        [JsonPropertyName("integer")]
        public int Integer { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [JsonPropertyName("number")]
        public decimal Number { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [JsonPropertyName("password")]
        public string Password { get; set; }

        /// <summary>
        /// A string that is a 10 digit number. Can have leading zeros.
        /// </summary>
        /// <value>A string that is a 10 digit number. Can have leading zeros.</value>
        [JsonPropertyName("pattern_with_digits")]
        public string PatternWithDigits { get; set; }

        /// <summary>
        /// A string starting with &#39;image_&#39; (case insensitive) and one to three digits following i.e. Image_01.
        /// </summary>
        /// <value>A string starting with &#39;image_&#39; (case insensitive) and one to three digits following i.e. Image_01.</value>
        [JsonPropertyName("pattern_with_digits_and_delimiter")]
        public string PatternWithDigitsAndDelimiter { get; set; }

        /// <summary>
        /// Gets or Sets String
        /// </summary>
        [JsonPropertyName("string")]
        public string String { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [JsonPropertyName("uuid")]
        public Guid Uuid { get; set; }

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
            sb.Append("class FormatTest {\n");
            sb.Append("  Binary: ").Append(Binary).Append("\n");
            sb.Append("  Byte: ").Append(Byte).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Decimal: ").Append(Decimal).Append("\n");
            sb.Append("  Double: ").Append(Double).Append("\n");
            sb.Append("  Float: ").Append(Float).Append("\n");
            sb.Append("  Int32: ").Append(Int32).Append("\n");
            sb.Append("  Int64: ").Append(Int64).Append("\n");
            sb.Append("  Integer: ").Append(Integer).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  PatternWithDigits: ").Append(PatternWithDigits).Append("\n");
            sb.Append("  PatternWithDigitsAndDelimiter: ").Append(PatternWithDigitsAndDelimiter).Append("\n");
            sb.Append("  String: ").Append(String).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
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
            // Double (double) maximum
            if (this.Double > (double)123.4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Double, must be a value less than or equal to 123.4.", new [] { "Double" });
            }

            // Double (double) minimum
            if (this.Double < (double)67.8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Double, must be a value greater than or equal to 67.8.", new [] { "Double" });
            }

            // Float (float) maximum
            if (this.Float > (float)987.6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Float, must be a value less than or equal to 987.6.", new [] { "Float" });
            }

            // Float (float) minimum
            if (this.Float < (float)54.3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Float, must be a value greater than or equal to 54.3.", new [] { "Float" });
            }

            // Int32 (int) maximum
            if (this.Int32 > (int)200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Int32, must be a value less than or equal to 200.", new [] { "Int32" });
            }

            // Int32 (int) minimum
            if (this.Int32 < (int)20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Int32, must be a value greater than or equal to 20.", new [] { "Int32" });
            }

            // Integer (int) maximum
            if (this.Integer > (int)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Integer, must be a value less than or equal to 100.", new [] { "Integer" });
            }

            // Integer (int) minimum
            if (this.Integer < (int)10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Integer, must be a value greater than or equal to 10.", new [] { "Integer" });
            }

            // Number (decimal) maximum
            if (this.Number > (decimal)543.2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Number, must be a value less than or equal to 543.2.", new [] { "Number" });
            }

            // Number (decimal) minimum
            if (this.Number < (decimal)32.1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Number, must be a value greater than or equal to 32.1.", new [] { "Number" });
            }

            // Password (string) maxLength
            if (this.Password != null && this.Password.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be less than 64.", new [] { "Password" });
            }

            // Password (string) minLength
            if (this.Password != null && this.Password.Length < 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be greater than 10.", new [] { "Password" });
            }

            // PatternWithDigits (string) pattern
            Regex regexPatternWithDigits = new Regex(@"^\\d{10}$", RegexOptions.CultureInvariant);
            if (false == regexPatternWithDigits.Match(this.PatternWithDigits).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PatternWithDigits, must match a pattern of " + regexPatternWithDigits, new [] { "PatternWithDigits" });
            }

            // PatternWithDigitsAndDelimiter (string) pattern
            Regex regexPatternWithDigitsAndDelimiter = new Regex(@"^image_\\d{1,3}$", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);
            if (false == regexPatternWithDigitsAndDelimiter.Match(this.PatternWithDigitsAndDelimiter).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PatternWithDigitsAndDelimiter, must match a pattern of " + regexPatternWithDigitsAndDelimiter, new [] { "PatternWithDigitsAndDelimiter" });
            }

            // String (string) pattern
            Regex regexString = new Regex(@"[a-z]", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);
            if (false == regexString.Match(this.String).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for String, must match a pattern of " + regexString, new [] { "String" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type FormatTest
    /// </summary>
    public class FormatTestJsonConverter : JsonConverter<FormatTest>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override FormatTest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject && reader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = reader.TokenType;

            System.IO.Stream binary = default;
            byte[] _byte = default;
            DateTime date = default;
            DateTime dateTime = default;
            decimal _decimal = default;
            double _double = default;
            float _float = default;
            int int32 = default;
            long int64 = default;
            int integer = default;
            decimal number = default;
            string password = default;
            string patternWithDigits = default;
            string patternWithDigitsAndDelimiter = default;
            string _string = default;
            Guid uuid = default;

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
                        case "binary":
                            Utf8JsonReader binaryReader = reader;
                            binary = JsonSerializer.Deserialize<System.IO.Stream>(ref reader, options);
                            break;
                        case "byte":
                            Utf8JsonReader _byteReader = reader;
                            _byte = JsonSerializer.Deserialize<byte[]>(ref reader, options);
                            break;
                        case "date":
                            Utf8JsonReader dateReader = reader;
                            date = JsonSerializer.Deserialize<DateTime>(ref reader, options);
                            break;
                        case "dateTime":
                            Utf8JsonReader dateTimeReader = reader;
                            dateTime = JsonSerializer.Deserialize<DateTime>(ref reader, options);
                            break;
                        case "decimal":
                            Utf8JsonReader _decimalReader = reader;
                            _decimal = JsonSerializer.Deserialize<decimal>(ref reader, options);
                            break;
                        case "double":
                            _double = reader.GetDouble();
                            break;
                        case "float":
                            _float = (float)reader.GetDouble();
                            break;
                        case "int32":
                            int32 = reader.GetInt32();
                            break;
                        case "int64":
                            int64 = reader.GetInt64();
                            break;
                        case "integer":
                            integer = reader.GetInt32();
                            break;
                        case "number":
                            number = reader.GetInt32();
                            break;
                        case "password":
                            password = reader.GetString();
                            break;
                        case "pattern_with_digits":
                            patternWithDigits = reader.GetString();
                            break;
                        case "pattern_with_digits_and_delimiter":
                            patternWithDigitsAndDelimiter = reader.GetString();
                            break;
                        case "string":
                            _string = reader.GetString();
                            break;
                        case "uuid":
                            uuid = reader.GetGuid();
                            break;
                    }
                }
            }

            return new FormatTest(binary, _byte, date, dateTime, _decimal, _double, _float, int32, int64, integer, number, password, patternWithDigits, patternWithDigitsAndDelimiter, _string, uuid);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="formatTest"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, FormatTest formatTest, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("binary");
            JsonSerializer.Serialize(writer, formatTest.Binary, options);
            writer.WritePropertyName("byte");
            JsonSerializer.Serialize(writer, formatTest.Byte, options);
            writer.WritePropertyName("date");
            JsonSerializer.Serialize(writer, formatTest.Date, options);
            writer.WritePropertyName("dateTime");
            JsonSerializer.Serialize(writer, formatTest.DateTime, options);
            writer.WritePropertyName("decimal");
            JsonSerializer.Serialize(writer, formatTest.Decimal, options);
            writer.WriteNumber("double", (int)formatTest.Double);
            writer.WriteNumber("float", (int)formatTest.Float);
            writer.WriteNumber("int32", (int)formatTest.Int32);
            writer.WriteNumber("int64", (int)formatTest.Int64);
            writer.WriteNumber("integer", (int)formatTest.Integer);
            writer.WriteNumber("number", (int)formatTest.Number);
            writer.WriteString("password", formatTest.Password);
            writer.WriteString("pattern_with_digits", formatTest.PatternWithDigits);
            writer.WriteString("pattern_with_digits_and_delimiter", formatTest.PatternWithDigitsAndDelimiter);
            writer.WriteString("string", formatTest.String);
            writer.WriteString("uuid", formatTest.Uuid);

            writer.WriteEndObject();
        }
    }
}
