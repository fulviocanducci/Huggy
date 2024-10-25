using Huggy.Configurations;
using Huggy.Https;
using Huggy.Models.Flows;
using System;
using System.Net.Http;
namespace Huggy
{
   public class HttpClientHuggy : IHttpClientHuggy
   {
      public const string BaseAddress = "https://api.huggy.app";
      public string Uuid { get; }
      private HttpClient HttpClient { get; }
      private Uri GetBaseAddress()
      {
         return new Uri(BaseAddress);
      }

      public Flow CreateFlow()
      {
         return new Flow(Uuid);
      }

      public HttpClientHuggy(HttpClient httpClient, IConfigurationHuggy configurationHuggy)
      {
         Uuid = configurationHuggy.Uuid;
         HttpClient = httpClient;
         HttpClient.BaseAddress = GetBaseAddress();
         httpClient.DefaultRequestHeaders.Clear();
         httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", configurationHuggy.ContentType);
         httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept", configurationHuggy.Accept);
         httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", configurationHuggy.Authorization);
         Agents = new AgentHttp(HttpClient);
         Flows = new FlowsHttp(HttpClient);
         Contacts = new ContactHttp(HttpClient);
      }

      public IAgentHttp Agents { get; }
      public IFlowsHttp Flows { get; }
      public IContactHttp Contacts { get; }
   }
}
