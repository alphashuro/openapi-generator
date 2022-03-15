/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;


/* *********************************************************************************
*              Follow these manual steps to construct tests.
*              This file will not be overwritten.
*  *********************************************************************************
* 1. Navigate to ApiTests.Base.cs and ensure any tokens are being created correctly.
*    Take care not to commit credentials to any repository.
*
* 2. Mocking is coordinated by ApiTestsBase#AddApiHttpClients.
*    To mock the client, use the generic AddApiHttpClients.
*    To mock the server, change the client's BaseAddress.
*
* 3. Locate the test you want below
*      - remove the skip property from the Fact attribute
*      - set the value of any variables if necessary
*
* 4. Run the tests and ensure they work.
*
*/


namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing FakeApi
    /// </summary>
    public sealed class FakeApiTests : ApiTestsBase
    {
        private readonly IFakeApi _instance;

        public FakeApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IFakeApi>();
        }


        /// <summary>
        /// Test FakeHealthGet
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task FakeHealthGetAsyncTest()
        {
            var response = await _instance.FakeHealthGetAsync();
            Assert.IsType<HealthCheckResult>(response);
        }

        /// <summary>
        /// Test FakeOuterBooleanSerialize
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task FakeOuterBooleanSerializeAsyncTest()
        {
            bool? body = default;
            var response = await _instance.FakeOuterBooleanSerializeAsync(body);
            Assert.IsType<bool>(response);
        }

        /// <summary>
        /// Test FakeOuterCompositeSerialize
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task FakeOuterCompositeSerializeAsyncTest()
        {
            OuterComposite outerComposite = default;
            var response = await _instance.FakeOuterCompositeSerializeAsync(outerComposite);
            Assert.IsType<OuterComposite>(response);
        }

        /// <summary>
        /// Test FakeOuterNumberSerialize
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task FakeOuterNumberSerializeAsyncTest()
        {
            decimal? body = default;
            var response = await _instance.FakeOuterNumberSerializeAsync(body);
            Assert.IsType<decimal>(response);
        }

        /// <summary>
        /// Test FakeOuterStringSerialize
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task FakeOuterStringSerializeAsyncTest()
        {
            string body = default;
            var response = await _instance.FakeOuterStringSerializeAsync(body);
            Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test GetArrayOfEnums
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetArrayOfEnumsAsyncTest()
        {
            var response = await _instance.GetArrayOfEnumsAsync();
            Assert.IsType<List<OuterEnum>>(response);
        }

        /// <summary>
        /// Test TestBodyWithFileSchema
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task TestBodyWithFileSchemaAsyncTest()
        {
            FileSchemaTestClass fileSchemaTestClass = default;
            await _instance.TestBodyWithFileSchemaAsync(fileSchemaTestClass);
        }

        /// <summary>
        /// Test TestBodyWithQueryParams
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task TestBodyWithQueryParamsAsyncTest()
        {
            string query = default;
            User user = default;
            await _instance.TestBodyWithQueryParamsAsync(query, user);
        }

        /// <summary>
        /// Test TestClientModel
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task TestClientModelAsyncTest()
        {
            ModelClient modelClient = default;
            var response = await _instance.TestClientModelAsync(modelClient);
            Assert.IsType<ModelClient>(response);
        }

        /// <summary>
        /// Test TestEndpointParameters
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task TestEndpointParametersAsyncTest()
        {
            decimal number = default;
            double _double = default;
            string patternWithoutDelimiter = default;
            byte[] _byte = default;
            int? integer = default;
            int? int32 = default;
            long? int64 = default;
            float? _float = default;
            string _string = default;
            System.IO.Stream binary = default;
            DateTime? date = default;
            string password = default;
            string callback = default;
            DateTime? dateTime = default;
            await _instance.TestEndpointParametersAsync(number, _double, patternWithoutDelimiter, _byte, integer, int32, int64, _float, _string, binary, date, password, callback, dateTime);
        }

        /// <summary>
        /// Test TestEnumParameters
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task TestEnumParametersAsyncTest()
        {
            List<string> enumHeaderStringArray = default;
            List<string> enumQueryStringArray = default;
            int? enumQueryInteger = default;
            double? enumQueryDouble = default;
            string enumHeaderString = default;
            string enumQueryString = default;
            List<string> enumFormStringArray = default;
            string enumFormString = default;
            await _instance.TestEnumParametersAsync(enumHeaderStringArray, enumQueryStringArray, enumQueryInteger, enumQueryDouble, enumHeaderString, enumQueryString, enumFormStringArray, enumFormString);
        }

        /// <summary>
        /// Test TestGroupParameters
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task TestGroupParametersAsyncTest()
        {
            int requiredStringGroup = default;
            bool requiredBooleanGroup = default;
            long requiredInt64Group = default;
            int? stringGroup = default;
            bool? booleanGroup = default;
            long? int64Group = default;
            await _instance.TestGroupParametersAsync(requiredStringGroup, requiredBooleanGroup, requiredInt64Group, stringGroup, booleanGroup, int64Group);
        }

        /// <summary>
        /// Test TestInlineAdditionalProperties
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task TestInlineAdditionalPropertiesAsyncTest()
        {
            Dictionary<string, string> requestBody = default;
            await _instance.TestInlineAdditionalPropertiesAsync(requestBody);
        }

        /// <summary>
        /// Test TestJsonFormData
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task TestJsonFormDataAsyncTest()
        {
            string param = default;
            string param2 = default;
            await _instance.TestJsonFormDataAsync(param, param2);
        }

        /// <summary>
        /// Test TestQueryParameterCollectionFormat
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task TestQueryParameterCollectionFormatAsyncTest()
        {
            List<string> pipe = default;
            List<string> ioutil = default;
            List<string> http = default;
            List<string> url = default;
            List<string> context = default;
            await _instance.TestQueryParameterCollectionFormatAsync(pipe, ioutil, http, url, context);
        }
    }
}
