using Huggy.Configurations;
using Huggy.Https;
using System;
using System.Net.Http;
namespace Huggy
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
         Flows = new FlowsHttp(HttpClient);
      }

      public IAgentHttp Agent { get; }
      public IFlowsHttp Flows { get; }
   }
}
