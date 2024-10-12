using Microsoft.Extensions.Configuration;

namespace Huggy.Configurations
{
   public class ConfigurationHuggy : IConfigurationHuggy
   {
      protected internal string SetAndGetAuthorization(string authorization) => $"Bearer {authorization}";

      public ConfigurationHuggy(IConfigurationManager configurationManager)
      {
         IConfigurationSection huggySection = configurationManager.GetSection("Huggy");
         ContentType = huggySection.GetSection("ContentType").Value;
         Accept = huggySection.GetSection("Accept").Value;
         Authorization = SetAndGetAuthorization(huggySection.GetSection("Authorization").Value);
      }

      public ConfigurationHuggy(string contentType, string accept, string authorization)
      {
         ContentType = contentType;
         Accept = accept;
         Authorization = SetAndGetAuthorization(authorization);
      }

      public string ContentType { get; }
      public string Accept { get; }
      public string Authorization { get; }
   }
}
