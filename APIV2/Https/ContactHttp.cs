using Huggy.Extensions;
using Huggy.Models;
using Huggy.Models.Contacts;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
namespace Huggy.Https
{
   public class ContactHttp : IContactHttp
   {
      private readonly HttpClient _httpClient;
      private const string UrlBase = "v2/contacts";
      public ContactHttp(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<IReturnOf<string>> DeleteAsync(int id)
      {
         HttpResponseMessage message = await _httpClient.DeleteAsync($"{UrlBase}/{id}");
         return await message.ReadOfTypeAsync<string>();
      }

      public async Task<IReturnOf<Contact>> GetAsync(int id)
      {
         HttpResponseMessage message = await _httpClient.GetAsync($"{UrlBase}/{id}");
         return await message.ReadOfTypeAsync<Contact>();
      }

      public async Task<IReturnOf<List<Contact>>> GetListAsync(int? page = null)
      {
         HttpResponseMessage message = await _httpClient.GetAsync($"{UrlBase}");
         return await message.ReadOfTypeAsync<List<Contact>>();
      }

      public async Task<IReturnOf<Contact>> PostAsync(ContactCreate model)
      {
         HttpResponseMessage message = await _httpClient.PostAsync($"{UrlBase}", model);
         IEnumerable<string> item = message
            .Headers
            .Where(x => x.Key.ToLower() == "location")
            .Select(c => c.Value)
            .FirstOrDefault();
         if (item != null && item.Any())
         {
            string locationId = item
               .ToList()[0]
               .Replace(@"/clients/", "");
            if (!string.IsNullOrEmpty(locationId) && int.TryParse(locationId, out int id))
            {
               return await GetAsync(id);
            }
         }
         return null;
      }

      public async Task<IReturnOf<string>> PutAsync(ContactUpdate model, int id)
      {
         HttpResponseMessage message = await _httpClient.PutAsync($"{UrlBase}/{id}", model);
         return await message.ReadOfTypeAsync<string>();
      }
   }
}