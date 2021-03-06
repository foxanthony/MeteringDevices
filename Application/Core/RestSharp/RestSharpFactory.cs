﻿using RestSharp;
using System;
using System.Net;

namespace MeteringDevices.Core.RestSharp
{
    class RestSharpFactory : IRestSharpFactory
    {
        private readonly IJsonSerializerFactory _JsonSerializerFactory;

        public RestSharpFactory(IJsonSerializerFactory jsonSerializerFactory)
        {
            if (jsonSerializerFactory == null)
            {
                throw new ArgumentNullException(nameof(jsonSerializerFactory));
            }

            _JsonSerializerFactory = jsonSerializerFactory;
        }

        public IRestClient CreateRestClient(Uri proxyUri)
        {
            RestClient restClient = new RestClient();

            if (proxyUri != null)
            {
                restClient.Proxy = new WebProxy(proxyUri);
            }

            restClient.AddHandler("application/json", _JsonSerializerFactory.CreateDeserializer);
            restClient.AddHandler("text/json", _JsonSerializerFactory.CreateDeserializer);

            return restClient;
        }

        public IRestRequest CreateRestRequest(string resource, Method method)
        {
            RestRequest restRequest = new RestRequest(resource, method);

            restRequest.JsonSerializer = _JsonSerializerFactory.CreateSerializer();

            return restRequest;
        }
    }
}
