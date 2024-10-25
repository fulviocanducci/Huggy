namespace Huggy.Configurations
{
   public class ConfigurationHuggy : IConfigurationHuggy
   {
      protected internal string SetAndGetAuthorization(string authorization) => $"Bearer {authorization}";

      public ConfigurationHuggy(string contentType, string accept, string authorization, string uuid)
      {
         ContentType = contentType;
         Accept = accept;
         Uuid = uuid;
         Authorization = SetAndGetAuthorization(authorization);
      }

      public string ContentType { get; }
      public string Accept { get; }
      public string Authorization { get; }
      public string Uuid { get; }
   }
}
