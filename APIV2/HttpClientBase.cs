using APIV2.Configurations;
using APIV2.Https;
using System;
using System.Net.Http;
namespace APIV2
{

   public class HttpClientHuggy : IHttpClientHuggy
   {
      public const string BaseAddress = "https://api.huggy.app";

      private HttpClient HttpClient { get; }
      private Uri GetBaseAddress()
      {
         return new Uri(BaseAddress);
      }

      public HttpClientHuggy(HttpClient httpClient, IConfigurationHuggy configurationHuggy)
      {
         HttpClient = httpClient;
         HttpClient.BaseAddress = GetBaseAddress();
         httpClient.DefaultRequestHeaders.Clear();
         httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", configurationHuggy.ContentType);
         httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept", configurationHuggy.Accept);
         httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", configurationHuggy.Authorization);
         Agent = new AgentHttp(HttpClient);
      }

      public IAgentHttp Agent { get; }
   }
}
