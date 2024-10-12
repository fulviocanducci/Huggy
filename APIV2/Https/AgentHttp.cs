using APIV2.Extensions;
using APIV2.Models;
using APIV2.Models.Agent;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
namespace APIV2.Https
{
   public class AgentHttp : IAgentHttp
   {
      private readonly HttpClient _httpClient;
      private const string UrlBase = "v2/agents";

      public AgentHttp(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }

      public async Task<IReturnOf<List<AgentList>>> GetListAsync(int? page = null)
      {
         HttpResponseMessage message = await _httpClient.GetAsync(UrlBase);
         return await message.ReadOfTypeAsync<List<AgentList>>();
      }

      public async Task<IReturnOf<Agent>> GetAsync(int id)
      {
         HttpResponseMessage message = await _httpClient.GetAsync($"{UrlBase}/{id}");
         return await message.ReadOfTypeAsync<Agent>();
      }
   }
}
