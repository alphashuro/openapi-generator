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
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// This class is registered as transient.
    /// </summary>
    public interface IFakeClassnameTags123Api : IApi
    {
        /// <summary>
        /// To test class name in snake case
        /// </summary>
        /// <remarks>
        /// To test class name in snake case
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient">client model</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;ModelClient&gt;&gt;</returns>
        Task<ApiResponse<ModelClient>> TestClassnameWithHttpInfoAsync(ModelClient modelClient, System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// To test class name in snake case
        /// </summary>
        /// <remarks>
        /// To test class name in snake case
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient">client model</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;ModelClient&gt;</returns>
        Task<ModelClient> TestClassnameAsync(ModelClient modelClient, System.Threading.CancellationToken? cancellationToken = null);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FakeClassnameTags123Api : IFakeClassnameTags123Api
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The EventHub
        /// </summary>
        public IEventHub EventHub { get; }

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<FakeClassnameTags123Api> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        public TokenProvider<ApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// A token provider of type <see cref="BearerToken"/>
        /// </summary>
        public TokenProvider<BearerToken> BearerTokenProvider { get; }

        /// <summary>
        /// A token provider of type <see cref="BasicTokenProvider"/>
        /// </summary>
        public TokenProvider<BasicToken> BasicTokenProvider { get; }

        /// <summary>
        /// A token provider of type <see cref="HttpSignatureTokenProvider"/>
        /// </summary>
        public TokenProvider<HttpSignatureToken> HttpSignatureTokenProvider { get; }

        /// <summary>
        /// A token provider of type <see cref="OauthTokenProvider"/>
        /// </summary>
        public TokenProvider<OAuthToken> OauthTokenProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FakeClassnameTags123Api"/> class.
        /// </summary>
        /// <returns></returns>
        public FakeClassnameTags123Api(ILogger<FakeClassnameTags123Api> logger, HttpClient httpClient, IEventHub eventHub, JsonSerializerOptionsProvider jsonSerializerOptionsProvider, 
            TokenProvider<ApiKeyToken> apiKeyProvider, 
            TokenProvider<BearerToken> bearerTokenProvider, 
            TokenProvider<BasicToken> basicTokenProvider, 
            TokenProvider<HttpSignatureToken> httpSignatureTokenProvider, 
            TokenProvider<OAuthToken> oauthTokenProvider)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            Logger = logger;
            HttpClient = httpClient;
            EventHub = eventHub;
            ApiKeyProvider = apiKeyProvider;
            BearerTokenProvider = bearerTokenProvider;
            BasicTokenProvider = basicTokenProvider;
            HttpSignatureTokenProvider = httpSignatureTokenProvider;
            OauthTokenProvider = oauthTokenProvider;
        }

        public virtual void OnApiResponded(ApiResponseEventArgs args)
        {
            EventHub.OnApiResponded(this, args);
        }

        /// <summary>
        /// To test class name in snake case To test class name in snake case
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient">client model</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ModelClient"/>&gt;</returns>
        public async Task<ModelClient> TestClassnameAsync(ModelClient modelClient, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<ModelClient> result = await TestClassnameWithHttpInfoAsync(modelClient, cancellationToken).ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        /// To test class name in snake case To test class name in snake case
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient">client model</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ModelClient"/>&gt;</returns>
        public async Task<ModelClient> TestClassnameOrDefaultAsync(ModelClient modelClient, System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<ModelClient> result = null;
            try 
            {
                result = await TestClassnameWithHttpInfoAsync(modelClient, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
            }

            return result != null && result.IsSuccessStatusCode
                ? result.Content
                : null;
        }

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="modelClient"></param>
        /// <returns></returns>
        public virtual ModelClient OnTestClassname(ModelClient modelClient)
        {
            #pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            #pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (modelClient == null)
                throw new ArgumentNullException(nameof(modelClient));

            #pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            #pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            return modelClient;
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponse"></param>
        /// <param name="modelClient"></param>
        public virtual void AfterTestClassname(ApiResponse<ModelClient> apiResponse, ModelClient modelClient)
        {
        }

        /// <summary>
        /// To test class name in snake case To test class name in snake case
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient">client model</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="ModelClient"/></returns>
        public async Task<ApiResponse<ModelClient>> TestClassnameWithHttpInfoAsync(ModelClient modelClient, System.Threading.CancellationToken? cancellationToken = null)
        {
            try
            {
                modelClient = OnTestClassname(modelClient);

                using (HttpRequestMessage request = new HttpRequestMessage())
                {
                    UriBuilder uriBuilder = new UriBuilder();
                    uriBuilder.Host = HttpClient.BaseAddress.Host;
                    uriBuilder.Scheme = ClientUtils.SCHEME;
                    uriBuilder.Path = ClientUtils.CONTEXT_PATH + "/fake_classname_test";

                    System.Collections.Specialized.NameValueCollection parseQueryString = System.Web.HttpUtility.ParseQueryString(string.Empty);

                    request.Content = (modelClient as object) is System.IO.Stream stream
                        ? request.Content = new StreamContent(stream)
                        : request.Content = new StringContent(JsonSerializer.Serialize(modelClient, _jsonSerializerOptions));

                    List<TokenBase> tokens = new List<TokenBase>();

                    ApiKeyToken apiKey = (ApiKeyToken) await ApiKeyProvider.GetAsync(cancellationToken).ConfigureAwait(false);

                    tokens.Add(apiKey);

                    apiKey.UseInQuery(request, uriBuilder, parseQueryString, "api_key_query");

                    uriBuilder.Query = parseQueryString.ToString();

                    request.RequestUri = uriBuilder.Uri;

                    string[] contentTypes = new string[] {
                        "application/json" 
                    };

                    string contentType = ClientUtils.SelectHeaderContentType(contentTypes);

                    if (contentType != null)
                        request.Content.Headers.Add("ContentType", contentType);

                    string[] accepts = new string[] { 
                        "application/json" 
                    };

                    string accept = ClientUtils.SelectHeaderAccept(accepts);

                    if (accept != null)
                        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(accept));

                    request.Method = HttpMethod.Patch;

                    using (HttpResponseMessage responseMessage = await HttpClient.SendAsync(request, cancellationToken.GetValueOrDefault()).ConfigureAwait(false))
                    {
                        DateTime requestedAt = DateTime.UtcNow;

                        string responseContent = await responseMessage.Content.ReadAsStringAsync(cancellationToken.GetValueOrDefault()).ConfigureAwait(false);

                        OnApiResponded(new ApiResponseEventArgs(requestedAt, DateTime.UtcNow, responseMessage.StatusCode, "/fake_classname_test"));

                        ApiResponse<ModelClient> apiResponse = new ApiResponse<ModelClient>(responseMessage, responseContent);

                        if (apiResponse.IsSuccessStatusCode)
                        {
                            apiResponse.Content = JsonSerializer.Deserialize<ModelClient>(apiResponse.RawContent, _jsonSerializerOptions);
                            AfterTestClassname(apiResponse, modelClient);
                        }
                        else if (apiResponse.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase token in tokens)
                                token.BeginRateLimit();

                        return apiResponse;
                    }
                }
            }
            catch(Exception e)
            {
                Logger.LogError(e, "An error occured while sending the request to the server.");
                throw;
            }
        }
    }
}
