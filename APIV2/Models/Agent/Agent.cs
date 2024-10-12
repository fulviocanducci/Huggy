using System.Text.Json.Serialization;
namespace Huggy.Models.Agent
{

   public class Agent : AgentBase<string>
   {
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