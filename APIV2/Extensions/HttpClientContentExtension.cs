using APIV2.Models;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace APIV2.Extensions
{
   internal static class HttpClientContentExtension
   {
      public static async Task<IReturnOf<T>> ReadOfTypeAsync<T>(this HttpResponseMessage message)
      {
         if (message.IsSuccessStatusCode)
         {
            var json = await message.Content.ReadAsStringAsync();
            T data = JsonSerializer.Deserialize<T>(json);
            return ReturnOf<T>.CreateSuccessStatusCode((int)message.StatusCode, data);
         }
         ReasonResult reasonResult = JsonSerializer.Deserialize<ReasonResult>(await message.Content.ReadAsStringAsync());
         return ReturnOf<T>.CreateErrorStatusCode((int)message.StatusCode, reasonResult.Reason);
      }
   }
}
