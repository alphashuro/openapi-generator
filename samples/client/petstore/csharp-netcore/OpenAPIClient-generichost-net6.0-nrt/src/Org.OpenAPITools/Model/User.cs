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
    /// User
    /// </summary>
    public partial class User : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="email">email</param>
        /// <param name="firstName">firstName</param>
        /// <param name="id">id</param>
        /// <param name="lastName">lastName</param>
        /// <param name="objectWithNoDeclaredProps">test code generation for objects Value must be a map of strings to values. It cannot be the &#39;null&#39; value.</param>
        /// <param name="password">password</param>
        /// <param name="phone">phone</param>
        /// <param name="userStatus">User Status</param>
        /// <param name="username">username</param>
        /// <param name="anyTypeProp">test code generation for any type Here the &#39;type&#39; attribute is not specified, which means the value can be anything, including the null value, string, number, boolean, array or object. See https://github.com/OAI/OpenAPI-Specification/issues/1389</param>
        /// <param name="anyTypePropNullable">test code generation for any type Here the &#39;type&#39; attribute is not specified, which means the value can be anything, including the null value, string, number, boolean, array or object. The &#39;nullable&#39; attribute does not change the allowed values.</param>
        /// <param name="objectWithNoDeclaredPropsNullable">test code generation for nullable objects. Value must be a map of strings to values or the &#39;null&#39; value.</param>
        [JsonConstructor]
        public User(string email, string firstName, long id, string lastName, Object objectWithNoDeclaredProps, string password, string phone, int userStatus, string username, Object? anyTypeProp = default, Object? anyTypePropNullable = default, Object? objectWithNoDeclaredPropsNullable = default)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (id == null)
                throw new ArgumentNullException("id is a required property for User and cannot be null.");

            if (username == null)
                throw new ArgumentNullException("username is a required property for User and cannot be null.");

            if (firstName == null)
                throw new ArgumentNullException("firstName is a required property for User and cannot be null.");

            if (lastName == null)
                throw new ArgumentNullException("lastName is a required property for User and cannot be null.");

            if (email == null)
                throw new ArgumentNullException("email is a required property for User and cannot be null.");

            if (password == null)
                throw new ArgumentNullException("password is a required property for User and cannot be null.");

            if (phone == null)
                throw new ArgumentNullException("phone is a required property for User and cannot be null.");

            if (userStatus == null)
                throw new ArgumentNullException("userStatus is a required property for User and cannot be null.");

            if (objectWithNoDeclaredProps == null)
                throw new ArgumentNullException("objectWithNoDeclaredProps is a required property for User and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            Email = email;
            FirstName = firstName;
            Id = id;
            LastName = lastName;
            ObjectWithNoDeclaredProps = objectWithNoDeclaredProps;
            Password = password;
            Phone = phone;
            UserStatus = userStatus;
            Username = username;
            AnyTypeProp = anyTypeProp;
            AnyTypePropNullable = anyTypePropNullable;
            ObjectWithNoDeclaredPropsNullable = objectWithNoDeclaredPropsNullable;
        }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// test code generation for objects Value must be a map of strings to values. It cannot be the &#39;null&#39; value.
        /// </summary>
        /// <value>test code generation for objects Value must be a map of strings to values. It cannot be the &#39;null&#39; value.</value>
        [JsonPropertyName("objectWithNoDeclaredProps")]
        public Object ObjectWithNoDeclaredProps { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [JsonPropertyName("password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// User Status
        /// </summary>
        /// <value>User Status</value>
        [JsonPropertyName("userStatus")]
        public int UserStatus { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [JsonPropertyName("username")]
        public string Username { get; set; }

        /// <summary>
        /// test code generation for any type Here the &#39;type&#39; attribute is not specified, which means the value can be anything, including the null value, string, number, boolean, array or object. See https://github.com/OAI/OpenAPI-Specification/issues/1389
        /// </summary>
        /// <value>test code generation for any type Here the &#39;type&#39; attribute is not specified, which means the value can be anything, including the null value, string, number, boolean, array or object. See https://github.com/OAI/OpenAPI-Specification/issues/1389</value>
        [JsonPropertyName("anyTypeProp")]
        public Object? AnyTypeProp { get; set; }

        /// <summary>
        /// test code generation for any type Here the &#39;type&#39; attribute is not specified, which means the value can be anything, including the null value, string, number, boolean, array or object. The &#39;nullable&#39; attribute does not change the allowed values.
        /// </summary>
        /// <value>test code generation for any type Here the &#39;type&#39; attribute is not specified, which means the value can be anything, including the null value, string, number, boolean, array or object. The &#39;nullable&#39; attribute does not change the allowed values.</value>
        [JsonPropertyName("anyTypePropNullable")]
        public Object? AnyTypePropNullable { get; set; }

        /// <summary>
        /// test code generation for nullable objects. Value must be a map of strings to values or the &#39;null&#39; value.
        /// </summary>
        /// <value>test code generation for nullable objects. Value must be a map of strings to values or the &#39;null&#39; value.</value>
        [JsonPropertyName("objectWithNoDeclaredPropsNullable")]
        public Object? ObjectWithNoDeclaredPropsNullable { get; set; }

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
            sb.Append("class User {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  ObjectWithNoDeclaredProps: ").Append(ObjectWithNoDeclaredProps).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  UserStatus: ").Append(UserStatus).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  AnyTypeProp: ").Append(AnyTypeProp).Append("\n");
            sb.Append("  AnyTypePropNullable: ").Append(AnyTypePropNullable).Append("\n");
            sb.Append("  ObjectWithNoDeclaredPropsNullable: ").Append(ObjectWithNoDeclaredPropsNullable).Append("\n");
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
    /// A Json converter for type User
    /// </summary>
    public class UserJsonConverter : JsonConverter<User>
    {
        /// <summary>
        /// Returns a boolean if the type is compatible with this converter.
        /// </summary>
        /// <param name="typeToConvert"></param>
        /// <returns></returns>
        public override bool CanConvert(Type typeToConvert) => typeof(User).IsAssignableFrom(typeToConvert);

        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override User Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int currentDepth = reader.CurrentDepth;

            if (reader.TokenType != JsonTokenType.StartObject && reader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            string email = default;
            string firstName = default;
            long id = default;
            string lastName = default;
            Object objectWithNoDeclaredProps = default;
            string password = default;
            string phone = default;
            int userStatus = default;
            string username = default;
            Object anyTypeProp = default;
            Object anyTypePropNullable = default;
            Object objectWithNoDeclaredPropsNullable = default;

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
                        case "email":
                            email = reader.GetString();
                            break;
                        case "firstName":
                            firstName = reader.GetString();
                            break;
                        case "id":
                            id = reader.GetInt64();
                            break;
                        case "lastName":
                            lastName = reader.GetString();
                            break;
                        case "objectWithNoDeclaredProps":
                            Utf8JsonReader objectWithNoDeclaredPropsReader = reader;
                            objectWithNoDeclaredProps = JsonSerializer.Deserialize<Object>(ref reader, options);
                            break;
                        case "password":
                            password = reader.GetString();
                            break;
                        case "phone":
                            phone = reader.GetString();
                            break;
                        case "userStatus":
                            userStatus = reader.GetInt32();
                            break;
                        case "username":
                            username = reader.GetString();
                            break;
                        case "anyTypeProp":
                            Utf8JsonReader anyTypePropReader = reader;
                            anyTypeProp = JsonSerializer.Deserialize<Object>(ref reader, options);
                            break;
                        case "anyTypePropNullable":
                            Utf8JsonReader anyTypePropNullableReader = reader;
                            anyTypePropNullable = JsonSerializer.Deserialize<Object>(ref reader, options);
                            break;
                        case "objectWithNoDeclaredPropsNullable":
                            Utf8JsonReader objectWithNoDeclaredPropsNullableReader = reader;
                            objectWithNoDeclaredPropsNullable = JsonSerializer.Deserialize<Object>(ref reader, options);
                            break;
                    }
                }
            }

            return new User(email, firstName, id, lastName, objectWithNoDeclaredProps, password, phone, userStatus, username, anyTypeProp, anyTypePropNullable, objectWithNoDeclaredPropsNullable);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="user"></param>
        /// <param name="options"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, User user, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, user);
        }
    }
}
