using Microsoft.Extensions.Configuration;

namespace APIV2.Configurations
{
   public class ConfigurationHuggy : IConfigurationHuggy
   {
      public ConfigurationHuggy(IConfigurationManager configurationManager)
      {
         IConfigurationSection huggySection = configurationManager.GetSection("Huggy");
         ContentType = huggySection.GetSection("ContentType").Value;
         Accept = huggySection.GetSection("Accept").Value;
         Authorization = huggySection.GetSection("Authorization").Value;
      }

      public ConfigurationHuggy(string contentType, string accept, string authorization)
      {
         ContentType = contentType;
         Accept = accept;
         Authorization = $"Bearer {authorization}";
      }

      public string ContentType { get; }
      public string Accept { get; }
      public string Authorization { get; }
   }
}
