using Huggy.Configurations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
namespace Huggy.Extensions
{
   public static class ServiceCollectionsExtension
   {
      public static IServiceCollection AddHuggy(this IServiceCollection services, string contentType, string accept, string authorization, string uuid)
      {
         services.AddScoped<IConfigurationHuggy>(_ => new ConfigurationHuggy(contentType, accept, authorization, uuid));
         services.TryAddScoped<IHttpClientHuggy, HttpClientHuggy>();
         return services;
      }
   }
}
