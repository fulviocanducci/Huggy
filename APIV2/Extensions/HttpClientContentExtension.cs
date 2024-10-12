using Huggy.Models;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Huggy.Extensions
{
   internal static class HttpClientContentExtension
   {
      internal static JsonSerializerOptions JsonSerializerOptions = new JsonSerializerOptions()
      {
         DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
      };

      public static async Task<IReturnOf<T>> ReadOfTypeAsync<T>(this HttpResponseMessage message)
      {
         if (message.IsSuccessStatusCode)
         {
            var json = await message.Content.ReadAsStringAsync();
            T data = JsonSerializer.Deserialize<T>(json, JsonSerializerOptions);
            return ReturnOf<T>.CreateSuccessStatusCode((int)message.StatusCode, data);
         }
         ReasonResult reasonResult = JsonSerializer.Deserialize<ReasonResult>(await message.Content.ReadAsStringAsync());
         return ReturnOf<T>.CreateErrorStatusCode((int)message.StatusCode, reasonResult.Reason);
      }

      public static async Task<HttpResponseMessage> PostAsync<T>(this HttpClient client, string url, T model) where T : class, new()
      {
         StringContent content = new StringContent
            (
            JsonSerializer.Serialize(model),
            Encoding.UTF8,
            "application/json"
            );
         return await client.PostAsync(url, content);
      }

      public static async Task<HttpResponseMessage> PostAsync<T>(this HttpClient client, string url, T model, CancellationToken cancellationToken) where T : class, new()
      {
         StringContent content = new StringContent
            (
            JsonSerializer.Serialize(model),
            Encoding.UTF8,
            "application/json"
            );
         return await client.PostAsync(url, content, cancellationToken);
      }

      public static async Task<HttpResponseMessage> PostAsync<T>(this HttpClient client, Uri url, T model) where T : class, new()
      {
         StringContent content = new StringContent
            (
            JsonSerializer.Serialize(model),
            Encoding.UTF8,
            "application/json"
            );
         return await client.PostAsync(url, content);
      }

      public static async Task<HttpResponseMessage> PostAsync<T>(this HttpClient client, Uri url, T model, CancellationToken cancellationToken) where T : class, new()
      {
         StringContent content = new StringContent
            (
            JsonSerializer.Serialize(model),
            Encoding.UTF8,
            "application/json"
            );
         return await client.PostAsync(url, content, cancellationToken);
      }


      public static async Task<HttpResponseMessage> PutAsync<T>(this HttpClient client, string url, T model) where T : class, new()
      {
         StringContent content = new StringContent
            (
            JsonSerializer.Serialize(model),
            Encoding.UTF8,
            "application/json"
            );
         return await client.PutAsync(url, content);
      }

      public static async Task<HttpResponseMessage> PutAsync<T>(this HttpClient client, string url, T model, CancellationToken cancellationToken) where T : class, new()
      {
         StringContent content = new StringContent
            (
            JsonSerializer.Serialize(model),
            Encoding.UTF8,
            "application/json"
            );
         return await client.PutAsync(url, content, cancellationToken);
      }

      public static async Task<HttpResponseMessage> PutAsync<T>(this HttpClient client, Uri url, T model) where T : class, new()
      {
         StringContent content = new StringContent
            (
            JsonSerializer.Serialize(model),
            Encoding.UTF8,
            "application/json"
            );
         return await client.PutAsync(url, content);
      }

      public static async Task<HttpResponseMessage> PutAsync<T>(this HttpClient client, Uri url, T model, CancellationToken cancellationToken) where T : class, new()
      {
         StringContent content = new StringContent
            (
            JsonSerializer.Serialize(model),
            Encoding.UTF8,
            "application/json"
            );
         return await client.PutAsync(url, content, cancellationToken);
      }

   }
}
