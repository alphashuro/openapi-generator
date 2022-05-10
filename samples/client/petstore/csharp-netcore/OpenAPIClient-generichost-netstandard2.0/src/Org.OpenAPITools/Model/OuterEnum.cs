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
    /// Defines OuterEnum
    /// </summary>
    public enum OuterEnum
    {
        /// <summary>
        /// Enum Placed for value: placed
        /// </summary>
        Placed = 1,

        /// <summary>
        /// Enum Approved for value: approved
        /// </summary>
        Approved = 2,

        /// <summary>
        /// Enum Delivered for value: delivered
        /// </summary>
        Delivered = 3
    }

    public class OuterEnumConverter : JsonConverter<OuterEnum>
    {
        public static OuterEnum? FromString(string value)
        {
            if (value == "placed")
                return OuterEnum.Placed;

            if (value == "approved")
                return OuterEnum.Approved;

            if (value == "delivered")
                return OuterEnum.Delivered;

            return null;
        }

        public static string ToJsonValue(OuterEnum value)
        {
            if (value == OuterEnum.Placed)
                return "placed";

            if (value == OuterEnum.Approved)
                return "approved";

            if (value == OuterEnum.Delivered)
                return "delivered";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override OuterEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string rawValue = reader.GetString();

            OuterEnum? result = OuterEnumConverter.FromString(rawValue);
            
            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the OuterEnum to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="outerEnum"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, OuterEnum outerEnum, JsonSerializerOptions options)
        {
            writer.WriteStringValue(outerEnum.ToString());
        }
    }

    public class OuterEnumNullableConverter : JsonConverter<OuterEnum?>
    {
        /// <summary>
        /// Returns a OuterEnum from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override OuterEnum? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string rawValue = reader.GetString();

            if (rawValue == null)
                return null;

            OuterEnum? result = OuterEnumConverter.FromString(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="outerEnum"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, OuterEnum? outerEnum, JsonSerializerOptions options)
        {
            writer.WriteStringValue(outerEnum?.ToString() ?? "null");
        }
    }

}
