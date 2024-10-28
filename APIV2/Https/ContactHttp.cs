using Huggy.Extensions;
using Huggy.Models;
using Huggy.Models.Contacts;
using System;
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
         return await DeleteAsync($"{id}");
      }

      public async Task<IReturnOf<string>> DeleteAsync(string id)
      {
         HttpResponseMessage message = await _httpClient.DeleteAsync($"{UrlBase}/{id}");
         return await message.ReadOfTypeAsync<string>();
      }

      public async Task<IReturnOf<Contact>> GetAsync(int id)
      {
         HttpResponseMessage message = await _httpClient.GetAsync($"{UrlBase}/{id}");
         return await message.ReadOfTypeAsync<Contact>();
      }

      public async Task<IReturnOf<List<Contact>>> ListAsync(string mobile, int? page = null)
      {
         HttpResponseMessage message = await _httpClient.GetAsync($"{UrlBase}?mobile={mobile}{(page != null ? $"&page={page}" : "")}");
         return await message.ReadOfTypeAsync<List<Contact>>();
      }

      public async Task<IReturnOf<List<Contact>>> ListAsync(int? page = null)
      {
         HttpResponseMessage message = await _httpClient.GetAsync($"{UrlBase}{(page != null ? $"?page={page}" : "")}");
         return await message.ReadOfTypeAsync<List<Contact>>();
      }

      public async Task<IReturnOf<Contact>> AddAsync(ContactCreate model)
      {
         IReturnOf<List<Contact>> contacts = await ListAsync(model.Mobile, null);
         if (contacts != null && contacts.IsValid)
         {
            Func<Contact, bool> where = c => c.Mobile == model.Mobile;
            if (contacts.Data.Any() && contacts.Data.Where(where).Any())
            {
               return ReturnOf<Contact>.CreateSuccessStatusCode(201, contacts.Data.FirstOrDefault(where));
            }
         }
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
         return ReturnOf<Contact>.CreateErrorStatusCode(500, "Server error 500");
      }

      public async Task<IReturnOf<string>> UpdateAsync(ContactUpdate model, int id)
      {
         HttpResponseMessage message = await _httpClient.PutAsync($"{UrlBase}/{id}", model);
         return await message.ReadOfTypeAsync<string>();
      }

      public async Task<IReturnOf<Contact>> GetAsync(string id)
      {
         if (int.TryParse(id, out int _id))
         {
            return await GetAsync(_id);
         }
         return null;
      }

      public async Task<IReturnOf<string>> UpdateAsync(ContactUpdate model, string id)
      {
         if (int.TryParse(id, out int _id))
         {
            return await UpdateAsync(model, _id);
         }
         return null;
      }


   }
}