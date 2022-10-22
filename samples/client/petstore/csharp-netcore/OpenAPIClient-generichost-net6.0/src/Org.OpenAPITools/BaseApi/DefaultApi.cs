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

namespace Org.OpenAPITools.IDefaultApi
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// This class is registered as transient.
    /// </summary>
    public interface IDefaultApi : IApi
    {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;FooGetDefaultResponse&gt;&gt;</returns>
        Task<ApiResponse<FooGetDefaultResponse>> FooGetWithHttpInfoAsync(System.Threading.CancellationToken? cancellationToken = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse&lt;FooGetDefaultResponse&gt;</returns>
        Task<FooGetDefaultResponse> FooGetAsync(System.Threading.CancellationToken? cancellationToken = null);
    }
}

namespace Org.OpenAPITools.BaseApi
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DefaultApi : IDefaultApi.IDefaultApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<DefaultApi> Logger { get; }

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
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(ILogger<DefaultApi> logger, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider, 
            TokenProvider<ApiKeyToken> apiKeyProvider, 
            TokenProvider<BearerToken> bearerTokenProvider, 
            TokenProvider<BasicToken> basicTokenProvider, 
            TokenProvider<HttpSignatureToken> httpSignatureTokenProvider, 
            TokenProvider<OAuthToken> oauthTokenProvider)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            Logger = logger;
            HttpClient = httpClient;
            ApiKeyProvider = apiKeyProvider;
            BearerTokenProvider = bearerTokenProvider;
            BasicTokenProvider = basicTokenProvider;
            HttpSignatureTokenProvider = httpSignatureTokenProvider;
            OauthTokenProvider = oauthTokenProvider;
        }

        /// <summary>
        /// Logs the api response
        /// </summary>
        /// <param name="args"></param>
        protected virtual void OnApiResponded(ApiResponseEventArgs args)
        {
            Logger.LogInformation("{0,-9} | {1} | {3}", (args.ReceivedAt - args.RequestedAt).TotalSeconds, args.HttpStatus, args.Path);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="FooGetDefaultResponse"/>&gt;</returns>
        public async Task<FooGetDefaultResponse> FooGetAsync(System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<FooGetDefaultResponse> result = await FooGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);

            if (result.Content == null)
                throw new ApiException(result.ReasonPhrase, result.StatusCode, result.RawContent);

            return result.Content;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="FooGetDefaultResponse"/>&gt;</returns>
        public async Task<FooGetDefaultResponse> FooGetOrDefaultAsync(System.Threading.CancellationToken? cancellationToken = null)
        {
            ApiResponse<FooGetDefaultResponse> result = null;
            try 
            {
                result = await FooGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
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
        /// <returns></returns>
        protected virtual void OnFooGet()
        {
            return;
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponse"></param>
        protected virtual void AfterFooGet(ApiResponse<FooGetDefaultResponse> apiResponse)
        {
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        protected virtual void OnErrorFooGet(Exception exception, string pathFormat, string path)
        {
            Logger.LogError(exception, "An error occured while sending the request to the server.");
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="FooGetDefaultResponse"/></returns>
        public async Task<ApiResponse<FooGetDefaultResponse>> FooGetWithHttpInfoAsync(System.Threading.CancellationToken? cancellationToken = null)
        {
            UriBuilder uriBuilder = new UriBuilder();

            try
            {
                OnFooGet();

                using (HttpRequestMessage request = new HttpRequestMessage())
                {
                    uriBuilder.Host = HttpClient.BaseAddress.Host;
                    uriBuilder.Port = HttpClient.BaseAddress.Port;
                    uriBuilder.Scheme = ClientUtils.SCHEME;
                    uriBuilder.Path = ClientUtils.CONTEXT_PATH + "/foo";



                    request.RequestUri = uriBuilder.Uri;

                    string[] accepts = new string[] { 
                        "application/json" 
                    };

                    string accept = ClientUtils.SelectHeaderAccept(accepts);

                    if (accept != null)
                        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(accept));

                    request.Method = HttpMethod.Get;

                    DateTime requestedAt = DateTime.UtcNow;

                    using (HttpResponseMessage responseMessage = await HttpClient.SendAsync(request, cancellationToken.GetValueOrDefault()).ConfigureAwait(false))
                    {
                        OnApiResponded(new ApiResponseEventArgs(requestedAt, DateTime.UtcNow, responseMessage.StatusCode, "/foo", uriBuilder.Path));

                        string responseContent = await responseMessage.Content.ReadAsStringAsync(cancellationToken.GetValueOrDefault()).ConfigureAwait(false);

                        ApiResponse<FooGetDefaultResponse> apiResponse = new ApiResponse<FooGetDefaultResponse>(responseMessage, responseContent);

                        if (apiResponse.IsSuccessStatusCode)
                        {
                            apiResponse.Content = JsonSerializer.Deserialize<FooGetDefaultResponse>(apiResponse.RawContent, _jsonSerializerOptions);
                            AfterFooGet(apiResponse);
                        }

                        return apiResponse;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorFooGet(e, "/foo", uriBuilder.Path);
                throw;
            }
        }
    }
}
