namespace Huggy.Configurations
{
   public class ConfigurationHuggy : IConfigurationHuggy
   {
      protected internal string SetAndGetAuthorization(string authorization) => $"Bearer {authorization}";

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
