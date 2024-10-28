using Huggy.Extensions;
using Huggy.Models;
using Huggy.Models.Agent;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
namespace Huggy.Https
{
   public class AgentHttp : IAgentHttp
   {
      private readonly HttpClient _httpClient;
      private const string UrlBase = "v2/agents";
      public AgentHttp(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }

      public async Task<IReturnOf<List<AgentList>>> ListAsync(int? page = null)
      {
         HttpResponseMessage message = await _httpClient.GetAsync($"{UrlBase}{(page != null ? ($"?page={page}") : "")}");
         return await message.ReadOfTypeAsync<List<AgentList>>();
      }

      public async Task<IReturnOf<Agent>> GetAsync(int id)
      {
         HttpResponseMessage message = await _httpClient.GetAsync($"{UrlBase}/{id}");
         return await message.ReadOfTypeAsync<Agent>();
      }

      public async Task AddAsync(AgentCreate model)
      {
         HttpResponseMessage message = await _httpClient.PostAsync($"{UrlBase}", model);
         await message.ReadOfTypeAsync<Agent>();
      }

      public async Task AddAsync(string email, int type)
      {
         await AddAsync(new AgentCreate(email, type));
      }

      public async Task<IReturnOf<Agent>> UpdateAsync(Agent model, int id)
      {
         HttpResponseMessage message = await _httpClient.PutAsync($"{UrlBase}/{id}", model);
         return await message.ReadOfTypeAsync<Agent>();
      }
   }
}
