﻿using Huggy.Models;
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

      internal static StringContent CreateContent(string json)
      {
         return new StringContent
           (
           json,
           Encoding.UTF8,
           "application/json"
           );
      }

      public static async Task<IReturnOf<T>> ReadOfTypeAsync<T>(this HttpResponseMessage message)
      {
         string json = await message.Content.ReadAsStringAsync();
         if (message.IsSuccessStatusCode)
         {
            T data = json == "" || string.IsNullOrEmpty(json)
               ? default
               : JsonSerializer.Deserialize<T>(json, JsonSerializerOptions);
            return ReturnOf<T>.CreateSuccessStatusCode((int)message.StatusCode, data);
         }
         return ReturnOf<T>.CreateErrorStatusCode((int)message.StatusCode, message.ReasonPhrase);
      }

      public static async Task<HttpResponseMessage> PostAsync<T>(this HttpClient client, string url, T model) where T : class, new()
      {
         StringContent content = CreateContent(JsonSerializer.Serialize(model));
         return await client.PostAsync(url, content);
      }

      public static async Task<HttpResponseMessage> PostAsync<T>(this HttpClient client, string url, T model, CancellationToken cancellationToken) where T : class, new()
      {
         StringContent content = CreateContent(JsonSerializer.Serialize(model));
         return await client.PostAsync(url, content, cancellationToken);
      }

      public static async Task<HttpResponseMessage> PostAsync<T>(this HttpClient client, Uri url, T model) where T : class, new()
      {
         StringContent content = CreateContent(JsonSerializer.Serialize(model));
         return await client.PostAsync(url, content);
      }

      public static async Task<HttpResponseMessage> PostAsync<T>(this HttpClient client, Uri url, T model, CancellationToken cancellationToken) where T : class, new()
      {
         StringContent content = CreateContent(JsonSerializer.Serialize(model));
         return await client.PostAsync(url, content, cancellationToken);
      }


      public static async Task<HttpResponseMessage> PutAsync<T>(this HttpClient client, string url, T model) where T : class, new()
      {
         StringContent content = CreateContent(JsonSerializer.Serialize(model));
         return await client.PutAsync(url, content);
      }

      public static async Task<HttpResponseMessage> PutAsync<T>(this HttpClient client, string url, T model, CancellationToken cancellationToken) where T : class, new()
      {
         StringContent content = CreateContent(JsonSerializer.Serialize(model));
         return await client.PutAsync(url, content, cancellationToken);
      }

      public static async Task<HttpResponseMessage> PutAsync<T>(this HttpClient client, Uri url, T model) where T : class, new()
      {
         StringContent content = CreateContent(JsonSerializer.Serialize(model));
         return await client.PutAsync(url, content);
      }

      public static async Task<HttpResponseMessage> PutAsync<T>(this HttpClient client, Uri url, T model, CancellationToken cancellationToken) where T : class, new()
      {
         StringContent content = CreateContent(JsonSerializer.Serialize(model));
         return await client.PutAsync(url, content, cancellationToken);
      }
   }
}
