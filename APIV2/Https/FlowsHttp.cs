using Huggy.Extensions;
using Huggy.Models;
using Huggy.Models.Flows;
using System.Net.Http;
using System.Threading.Tasks;
namespace Huggy.Https
{
   //POST/flows/{flowId}/contact/{contactId}/exec
   public class FlowsHttp : IFlowsHttp
   {
      private readonly HttpClient _httpClient;
      private const string UrlBase = "v2/flows";
      public FlowsHttp(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }

      public async Task<IReturnOf<FlowReason>> SendAsync(string flowId, string contactId, Flow model)
      {
         HttpResponseMessage message = await _httpClient.PostAsync($"{UrlBase}/{flowId}/contact/{contactId}/exec", model);
         return await message.ReadOfTypeAsync<FlowReason>();
      }
   }
}