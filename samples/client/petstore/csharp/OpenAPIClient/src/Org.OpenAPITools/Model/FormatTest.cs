/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// FormatTest
    /// </summary>
    [DataContract]
    public partial class FormatTest :  IEquatable<FormatTest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormatTest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FormatTest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FormatTest" /> class.
        /// </summary>
        /// <param name="integer">integer.</param>
        /// <param name="int32">int32.</param>
        /// <param name="int64">int64.</param>
        /// <param name="number">number (required).</param>
        /// <param name="propertyFloat">propertyFloat.</param>
        /// <param name="propertyDouble">propertyDouble.</param>
        /// <param name="propertyDecimal">propertyDecimal.</param>
        /// <param name="propertyString">propertyString.</param>
        /// <param name="propertyByte">propertyByte (required).</param>
        /// <param name="binary">binary.</param>
        /// <param name="date">date (required).</param>
        /// <param name="dateTime">dateTime.</param>
        /// <param name="uuid">uuid.</param>
        /// <param name="password">password (required).</param>
        /// <param name="patternWithDigits">A string that is a 10 digit number. Can have leading zeros..</param>
        /// <param name="patternWithDigitsAndDelimiter">A string starting with &#39;image_&#39; (case insensitive) and one to three digits following i.e. Image_01..</param>
        public FormatTest(int integer = default(int), int int32 = default(int), long int64 = default(long), decimal number = default(decimal), float propertyFloat = default(float), double propertyDouble = default(double), decimal propertyDecimal = default(decimal), string propertyString = default(string), byte[] propertyByte = default(byte[]), System.IO.Stream binary = default(System.IO.Stream), DateTime date = default(DateTime), DateTime dateTime = default(DateTime), Guid uuid = default(Guid), string password = default(string), string patternWithDigits = default(string), string patternWithDigitsAndDelimiter = default(string))
        {
            // to ensure "number" is required (not null)
            if (number == null)
            {
                throw new InvalidDataException("number is a required property for FormatTest and cannot be null");
            }
            else
            {
                this.Number = number;
            }

            // to ensure "propertyByte" is required (not null)
            if (propertyByte == null)
            {
                throw new InvalidDataException("propertyByte is a required property for FormatTest and cannot be null");
            }
            else
            {
                this.PropertyByte = propertyByte;
            }

            // to ensure "date" is required (not null)
            if (date == null)
            {
                throw new InvalidDataException("date is a required property for FormatTest and cannot be null");
            }
            else
            {
                this.Date = date;
            }

            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new InvalidDataException("password is a required property for FormatTest and cannot be null");
            }
            else
            {
                this.Password = password;
            }

            this.Integer = integer;
            this.Int32 = int32;
            this.Int64 = int64;
            this.PropertyFloat = propertyFloat;
            this.PropertyDouble = propertyDouble;
            this.PropertyDecimal = propertyDecimal;
            this.PropertyString = propertyString;
            this.Binary = binary;
            this.DateTime = dateTime;
            this.Uuid = uuid;
            this.PatternWithDigits = patternWithDigits;
            this.PatternWithDigitsAndDelimiter = patternWithDigitsAndDelimiter;
        }

        /// <summary>
        /// Gets or Sets Integer
        /// </summary>
        [DataMember(Name="integer", EmitDefaultValue=false)]
        public int Integer { get; set; }

        /// <summary>
        /// Gets or Sets Int32
        /// </summary>
        [DataMember(Name="int32", EmitDefaultValue=false)]
        public int Int32 { get; set; }

        /// <summary>
        /// Gets or Sets Int64
        /// </summary>
        [DataMember(Name="int64", EmitDefaultValue=false)]
        public long Int64 { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue=true)]
        public decimal Number { get; set; }

        /// <summary>
        /// Gets or Sets PropertyFloat
        /// </summary>
        [DataMember(Name="float", EmitDefaultValue=false)]
        public float PropertyFloat { get; set; }

        /// <summary>
        /// Gets or Sets PropertyDouble
        /// </summary>
        [DataMember(Name="double", EmitDefaultValue=false)]
        public double PropertyDouble { get; set; }

        /// <summary>
        /// Gets or Sets PropertyDecimal
        /// </summary>
        [DataMember(Name="decimal", EmitDefaultValue=false)]
        public decimal PropertyDecimal { get; set; }

        /// <summary>
        /// Gets or Sets PropertyString
        /// </summary>
        [DataMember(Name="string", EmitDefaultValue=false)]
        public string PropertyString { get; set; }

        /// <summary>
        /// Gets or Sets PropertyByte
        /// </summary>
        [DataMember(Name="byte", EmitDefaultValue=true)]
        public byte[] PropertyByte { get; set; }

        /// <summary>
        /// Gets or Sets Binary
        /// </summary>
        [DataMember(Name="binary", EmitDefaultValue=false)]
        public System.IO.Stream Binary { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or Sets DateTime
        /// </summary>
        [DataMember(Name="dateTime", EmitDefaultValue=false)]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public Guid Uuid { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=true)]
        public string Password { get; set; }

        /// <summary>
        /// A string that is a 10 digit number. Can have leading zeros.
        /// </summary>
        /// <value>A string that is a 10 digit number. Can have leading zeros.</value>
        [DataMember(Name="pattern_with_digits", EmitDefaultValue=false)]
        public string PatternWithDigits { get; set; }

        /// <summary>
        /// A string starting with &#39;image_&#39; (case insensitive) and one to three digits following i.e. Image_01.
        /// </summary>
        /// <value>A string starting with &#39;image_&#39; (case insensitive) and one to three digits following i.e. Image_01.</value>
        [DataMember(Name="pattern_with_digits_and_delimiter", EmitDefaultValue=false)]
        public string PatternWithDigitsAndDelimiter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormatTest {\n");
            sb.Append("  Integer: ").Append(Integer).Append("\n");
            sb.Append("  Int32: ").Append(Int32).Append("\n");
            sb.Append("  Int64: ").Append(Int64).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  PropertyFloat: ").Append(PropertyFloat).Append("\n");
            sb.Append("  PropertyDouble: ").Append(PropertyDouble).Append("\n");
            sb.Append("  PropertyDecimal: ").Append(PropertyDecimal).Append("\n");
            sb.Append("  PropertyString: ").Append(PropertyString).Append("\n");
            sb.Append("  PropertyByte: ").Append(PropertyByte).Append("\n");
            sb.Append("  Binary: ").Append(Binary).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  PatternWithDigits: ").Append(PatternWithDigits).Append("\n");
            sb.Append("  PatternWithDigitsAndDelimiter: ").Append(PatternWithDigitsAndDelimiter).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FormatTest);
        }

        /// <summary>
        /// Returns true if FormatTest instances are equal
        /// </summary>
        /// <param name="input">Instance of FormatTest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormatTest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Integer == input.Integer ||
                    (this.Integer != null &&
                    this.Integer.Equals(input.Integer))
                ) && 
                (
                    this.Int32 == input.Int32 ||
                    (this.Int32 != null &&
                    this.Int32.Equals(input.Int32))
                ) && 
                (
                    this.Int64 == input.Int64 ||
                    (this.Int64 != null &&
                    this.Int64.Equals(input.Int64))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.PropertyFloat == input.PropertyFloat ||
                    (this.PropertyFloat != null &&
                    this.PropertyFloat.Equals(input.PropertyFloat))
                ) && 
                (
                    this.PropertyDouble == input.PropertyDouble ||
                    (this.PropertyDouble != null &&
                    this.PropertyDouble.Equals(input.PropertyDouble))
                ) && 
                (
                    this.PropertyDecimal == input.PropertyDecimal ||
                    (this.PropertyDecimal != null &&
                    this.PropertyDecimal.Equals(input.PropertyDecimal))
                ) && 
                (
                    this.PropertyString == input.PropertyString ||
                    (this.PropertyString != null &&
                    this.PropertyString.Equals(input.PropertyString))
                ) && 
                (
                    this.PropertyByte == input.PropertyByte ||
                    (this.PropertyByte != null &&
                    this.PropertyByte.Equals(input.PropertyByte))
                ) && 
                (
                    this.Binary == input.Binary ||
                    (this.Binary != null &&
                    this.Binary.Equals(input.Binary))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.DateTime == input.DateTime ||
                    (this.DateTime != null &&
                    this.DateTime.Equals(input.DateTime))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.PatternWithDigits == input.PatternWithDigits ||
                    (this.PatternWithDigits != null &&
                    this.PatternWithDigits.Equals(input.PatternWithDigits))
                ) && 
                (
                    this.PatternWithDigitsAndDelimiter == input.PatternWithDigitsAndDelimiter ||
                    (this.PatternWithDigitsAndDelimiter != null &&
                    this.PatternWithDigitsAndDelimiter.Equals(input.PatternWithDigitsAndDelimiter))
                );
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
                if (this.Integer != null)
                    hashCode = hashCode * 59 + this.Integer.GetHashCode();
                if (this.Int32 != null)
                    hashCode = hashCode * 59 + this.Int32.GetHashCode();
                if (this.Int64 != null)
                    hashCode = hashCode * 59 + this.Int64.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.PropertyFloat != null)
                    hashCode = hashCode * 59 + this.PropertyFloat.GetHashCode();
                if (this.PropertyDouble != null)
                    hashCode = hashCode * 59 + this.PropertyDouble.GetHashCode();
                if (this.PropertyDecimal != null)
                    hashCode = hashCode * 59 + this.PropertyDecimal.GetHashCode();
                if (this.PropertyString != null)
                    hashCode = hashCode * 59 + this.PropertyString.GetHashCode();
                if (this.PropertyByte != null)
                    hashCode = hashCode * 59 + this.PropertyByte.GetHashCode();
                if (this.Binary != null)
                    hashCode = hashCode * 59 + this.Binary.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.DateTime != null)
                    hashCode = hashCode * 59 + this.DateTime.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.PatternWithDigits != null)
                    hashCode = hashCode * 59 + this.PatternWithDigits.GetHashCode();
                if (this.PatternWithDigitsAndDelimiter != null)
                    hashCode = hashCode * 59 + this.PatternWithDigitsAndDelimiter.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {


            // Integer (int) maximum
            if(this.Integer > (int)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Integer, must be a value less than or equal to 100.", new [] { "Integer" });
            }

            // Integer (int) minimum
            if(this.Integer < (int)10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Integer, must be a value greater than or equal to 10.", new [] { "Integer" });
            }



            // Int32 (int) maximum
            if(this.Int32 > (int)200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Int32, must be a value less than or equal to 200.", new [] { "Int32" });
            }

            // Int32 (int) minimum
            if(this.Int32 < (int)20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Int32, must be a value greater than or equal to 20.", new [] { "Int32" });
            }



            // Number (decimal) maximum
            if(this.Number > (decimal)543.2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Number, must be a value less than or equal to 543.2.", new [] { "Number" });
            }

            // Number (decimal) minimum
            if(this.Number < (decimal)32.1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Number, must be a value greater than or equal to 32.1.", new [] { "Number" });
            }



            // PropertyFloat (float) maximum
            if(this.PropertyFloat > (float)987.6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PropertyFloat, must be a value less than or equal to 987.6.", new [] { "PropertyFloat" });
            }

            // PropertyFloat (float) minimum
            if(this.PropertyFloat < (float)54.3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PropertyFloat, must be a value greater than or equal to 54.3.", new [] { "PropertyFloat" });
            }



            // PropertyDouble (double) maximum
            if(this.PropertyDouble > (double)123.4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PropertyDouble, must be a value less than or equal to 123.4.", new [] { "PropertyDouble" });
            }

            // PropertyDouble (double) minimum
            if(this.PropertyDouble < (double)67.8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PropertyDouble, must be a value greater than or equal to 67.8.", new [] { "PropertyDouble" });
            }



            // PropertyString (string) pattern
            Regex regexPropertyString = new Regex(@"[a-z]", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);
            if (false == regexPropertyString.Match(this.PropertyString).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PropertyString, must match a pattern of " + regexPropertyString, new [] { "PropertyString" });
            }

            // Password (string) maxLength
            if(this.Password != null && this.Password.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Password, length must be less than 64.", new [] { "Password" });
            }

            // Password (string) minLength
            if(this.Password != null && this.Password.Length < 10)
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

            yield break;
        }
    }

}
