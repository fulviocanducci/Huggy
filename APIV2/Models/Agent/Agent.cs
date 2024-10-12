using System.Text.Json.Serialization;
namespace APIV2.Models.Agent
{
   public class Agent
   {
      [JsonPropertyName("id")]
      public string Id { get; set; }

      [JsonPropertyName("name")]
      public string Name { get; set; }

      [JsonPropertyName("email")]
      public string Email { get; set; }

      [JsonPropertyName("login")]
      public string Login { get; set; }

      [JsonPropertyName("type")]
      public int Type { get; set; }

      [JsonIgnore()]
      public string TypeLabel
      {
         get
         {
            if (Type == 1)
            {
               return "Agent";
            }
            else if (Type == 2)
            {
               return "Gerente";
            }
            else if (Type == 3)
            {
               return "Administrador";
            }
            return "";
         }
      }

      [JsonPropertyName("phone")]
      public string Phone { get; set; }

      [JsonPropertyName("password")]
      public string Password { get; set; }

      [JsonPropertyName("active")]
      public bool Active { get; set; }
   }
}