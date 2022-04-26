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
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Client
{
    /// <summary>
    /// Provides hosting configuration for Org.OpenAPITools
    /// </summary>
    public class HostConfiguration<TAnotherFakeApi, TDefaultApi, TFakeApi, TFakeClassnameTags123Api, TPetApi, TStoreApi, TUserApi>
        where TAnotherFakeApi : class, IAnotherFakeApi
        where TDefaultApi : class, IDefaultApi
        where TFakeApi : class, IFakeApi
        where TFakeClassnameTags123Api : class, IFakeClassnameTags123Api
        where TPetApi : class, IPetApi
        where TStoreApi : class, IStoreApi
        where TUserApi : class, IUserApi
    {
        private readonly IServiceCollection _services;
        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions();

        internal bool HttpClientsAdded { get; private set; }

        /// <summary>
        /// Instantiates the class 
        /// </summary>
        /// <param name="services"></param>
        public HostConfiguration(IServiceCollection services)
        {
            _services = services;
            _jsonOptions.Converters.Add(new JsonStringEnumConverter());
            _jsonOptions.Converters.Add(new OpenAPIDateJsonConverter());
            _jsonOptions.Converters.Add(new AdditionalPropertiesClassJsonConverter());
            _jsonOptions.Converters.Add(new AnimalJsonConverter());
            _jsonOptions.Converters.Add(new ApiResponseJsonConverter());
            _jsonOptions.Converters.Add(new AppleJsonConverter());
            _jsonOptions.Converters.Add(new AppleReqJsonConverter());
            _jsonOptions.Converters.Add(new ArrayOfArrayOfNumberOnlyJsonConverter());
            _jsonOptions.Converters.Add(new ArrayOfNumberOnlyJsonConverter());
            _jsonOptions.Converters.Add(new ArrayTestJsonConverter());
            _jsonOptions.Converters.Add(new BananaJsonConverter());
            _jsonOptions.Converters.Add(new BananaReqJsonConverter());
            _jsonOptions.Converters.Add(new BasquePigJsonConverter());
            _jsonOptions.Converters.Add(new CapitalizationJsonConverter());
            _jsonOptions.Converters.Add(new CatJsonConverter());
            _jsonOptions.Converters.Add(new CatAllOfJsonConverter());
            _jsonOptions.Converters.Add(new CategoryJsonConverter());
            _jsonOptions.Converters.Add(new ChildCatJsonConverter());
            _jsonOptions.Converters.Add(new ChildCatAllOfJsonConverter());
            _jsonOptions.Converters.Add(new ClassModelJsonConverter());
            _jsonOptions.Converters.Add(new ComplexQuadrilateralJsonConverter());
            _jsonOptions.Converters.Add(new DanishPigJsonConverter());
            _jsonOptions.Converters.Add(new DeprecatedObjectJsonConverter());
            _jsonOptions.Converters.Add(new DogJsonConverter());
            _jsonOptions.Converters.Add(new DogAllOfJsonConverter());
            _jsonOptions.Converters.Add(new DrawingJsonConverter());
            _jsonOptions.Converters.Add(new EnumArraysJsonConverter());
            _jsonOptions.Converters.Add(new EnumClassConverter());
            _jsonOptions.Converters.Add(new EnumClassNullableConverter());
            _jsonOptions.Converters.Add(new EnumTestJsonConverter());
            _jsonOptions.Converters.Add(new EquilateralTriangleJsonConverter());
            _jsonOptions.Converters.Add(new FileJsonConverter());
            _jsonOptions.Converters.Add(new FileSchemaTestClassJsonConverter());
            _jsonOptions.Converters.Add(new FooJsonConverter());
            _jsonOptions.Converters.Add(new FormatTestJsonConverter());
            _jsonOptions.Converters.Add(new FruitJsonConverter());
            _jsonOptions.Converters.Add(new FruitReqJsonConverter());
            _jsonOptions.Converters.Add(new GmFruitJsonConverter());
            _jsonOptions.Converters.Add(new GrandparentAnimalJsonConverter());
            _jsonOptions.Converters.Add(new HasOnlyReadOnlyJsonConverter());
            _jsonOptions.Converters.Add(new HealthCheckResultJsonConverter());
            _jsonOptions.Converters.Add(new InlineResponseDefaultJsonConverter());
            _jsonOptions.Converters.Add(new IsoscelesTriangleJsonConverter());
            _jsonOptions.Converters.Add(new ListJsonConverter());
            _jsonOptions.Converters.Add(new MammalJsonConverter());
            _jsonOptions.Converters.Add(new MapTestJsonConverter());
            _jsonOptions.Converters.Add(new MixedPropertiesAndAdditionalPropertiesClassJsonConverter());
            _jsonOptions.Converters.Add(new Model200ResponseJsonConverter());
            _jsonOptions.Converters.Add(new ModelClientJsonConverter());
            _jsonOptions.Converters.Add(new NameJsonConverter());
            _jsonOptions.Converters.Add(new NullableClassJsonConverter());
            _jsonOptions.Converters.Add(new NullableShapeJsonConverter());
            _jsonOptions.Converters.Add(new NumberOnlyJsonConverter());
            _jsonOptions.Converters.Add(new ObjectWithDeprecatedFieldsJsonConverter());
            _jsonOptions.Converters.Add(new OrderJsonConverter());
            _jsonOptions.Converters.Add(new OuterCompositeJsonConverter());
            _jsonOptions.Converters.Add(new OuterEnumConverter());
            _jsonOptions.Converters.Add(new OuterEnumNullableConverter());
            _jsonOptions.Converters.Add(new OuterEnumDefaultValueConverter());
            _jsonOptions.Converters.Add(new OuterEnumDefaultValueNullableConverter());
            _jsonOptions.Converters.Add(new OuterEnumIntegerConverter());
            _jsonOptions.Converters.Add(new OuterEnumIntegerNullableConverter());
            _jsonOptions.Converters.Add(new OuterEnumIntegerDefaultValueConverter());
            _jsonOptions.Converters.Add(new OuterEnumIntegerDefaultValueNullableConverter());
            _jsonOptions.Converters.Add(new ParentPetJsonConverter());
            _jsonOptions.Converters.Add(new PetJsonConverter());
            _jsonOptions.Converters.Add(new PigJsonConverter());
            _jsonOptions.Converters.Add(new PolymorphicPropertyJsonConverter());
            _jsonOptions.Converters.Add(new QuadrilateralJsonConverter());
            _jsonOptions.Converters.Add(new QuadrilateralInterfaceJsonConverter());
            _jsonOptions.Converters.Add(new ReadOnlyFirstJsonConverter());
            _jsonOptions.Converters.Add(new ReturnJsonConverter());
            _jsonOptions.Converters.Add(new ScaleneTriangleJsonConverter());
            _jsonOptions.Converters.Add(new ShapeJsonConverter());
            _jsonOptions.Converters.Add(new ShapeInterfaceJsonConverter());
            _jsonOptions.Converters.Add(new ShapeOrNullJsonConverter());
            _jsonOptions.Converters.Add(new SimpleQuadrilateralJsonConverter());
            _jsonOptions.Converters.Add(new SpecialModelNameJsonConverter());
            _jsonOptions.Converters.Add(new TagJsonConverter());
            _jsonOptions.Converters.Add(new TriangleJsonConverter());
            _jsonOptions.Converters.Add(new TriangleInterfaceJsonConverter());
            _jsonOptions.Converters.Add(new UserJsonConverter());
            _jsonOptions.Converters.Add(new WhaleJsonConverter());
            _jsonOptions.Converters.Add(new ZebraJsonConverter());
            _services.AddSingleton(new JsonSerializerOptionsProvider(_jsonOptions));
            _services.AddSingleton<IEventHub, EventHub>();
            _services.AddSingleton<IApiFactory, ApiFactory>();
            _services.AddTransient<TAnotherFakeApi, TAnotherFakeApi>();
            _services.AddTransient<TDefaultApi, TDefaultApi>();
            _services.AddTransient<TFakeApi, TFakeApi>();
            _services.AddTransient<TFakeClassnameTags123Api, TFakeClassnameTags123Api>();
            _services.AddTransient<TPetApi, TPetApi>();
            _services.AddTransient<TStoreApi, TStoreApi>();
            _services.AddTransient<TUserApi, TUserApi>();
        }

        /// <summary>
        /// Configures the HttpClients.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="builder"></param>
        /// <returns></returns>
        public HostConfiguration<TAnotherFakeApi, TDefaultApi, TFakeApi, TFakeClassnameTags123Api, TPetApi, TStoreApi, TUserApi> AddApiHttpClients
        (
            Action<HttpClient>? client = null, Action<IHttpClientBuilder>? builder = null)
        {
            if (client == null)
                client = c => c.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS);

            List<IHttpClientBuilder> builders = new List<IHttpClientBuilder>();

            builders.Add(_services.AddHttpClient<IAnotherFakeApi, TAnotherFakeApi>(client));
            builders.Add(_services.AddHttpClient<IDefaultApi, TDefaultApi>(client));
            builders.Add(_services.AddHttpClient<IFakeApi, TFakeApi>(client));
            builders.Add(_services.AddHttpClient<IFakeClassnameTags123Api, TFakeClassnameTags123Api>(client));
            builders.Add(_services.AddHttpClient<IPetApi, TPetApi>(client));
            builders.Add(_services.AddHttpClient<IStoreApi, TStoreApi>(client));
            builders.Add(_services.AddHttpClient<IUserApi, TUserApi>(client));
            
            if (builder != null)
                foreach (IHttpClientBuilder instance in builders)
                    builder(instance);

            HttpClientsAdded = true;

            return this;
        }

        /// <summary>
        /// Configures the JsonSerializerSettings
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public HostConfiguration<TAnotherFakeApi, TDefaultApi, TFakeApi, TFakeClassnameTags123Api, TPetApi, TStoreApi, TUserApi> ConfigureJsonOptions(Action<JsonSerializerOptions> options)
        {
            options(_jsonOptions);

            return this;
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="token"></param>
        /// <returns></returns>
        public HostConfiguration<TAnotherFakeApi, TDefaultApi, TFakeApi, TFakeClassnameTags123Api, TPetApi, TStoreApi, TUserApi> AddTokens<TTokenBase>(TTokenBase token) where TTokenBase : TokenBase
        {
            return AddTokens(new TTokenBase[]{ token });
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="tokens"></param>
        /// <returns></returns>
        public HostConfiguration<TAnotherFakeApi, TDefaultApi, TFakeApi, TFakeClassnameTags123Api, TPetApi, TStoreApi, TUserApi> AddTokens<TTokenBase>(IEnumerable<TTokenBase> tokens) where TTokenBase : TokenBase
        {
            TokenContainer<TTokenBase> container = new TokenContainer<TTokenBase>(tokens);
            _services.AddSingleton(services => container);

            return this;
        }

        /// <summary>
        /// Adds a token provider to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenProvider"></typeparam>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <returns></returns>
        public HostConfiguration<TAnotherFakeApi, TDefaultApi, TFakeApi, TFakeClassnameTags123Api, TPetApi, TStoreApi, TUserApi> UseProvider<TTokenProvider, TTokenBase>() 
            where TTokenProvider : TokenProvider<TTokenBase>
            where TTokenBase : TokenBase
        {
            _services.AddSingleton<TTokenProvider>();
            _services.AddSingleton<TokenProvider<TTokenBase>>(services => services.GetRequiredService<TTokenProvider>());

            return this;
        }
    }
}
