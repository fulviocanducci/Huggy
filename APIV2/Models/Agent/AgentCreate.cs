using System.Text.Json.Serialization;
namespace APIV2.Models.Agent
{
   public class AgentCreate
   {
      public AgentCreate()
      {

      }
      public AgentCreate(string email, int type)
      {
         Email = email;
         Type = type;
      }

      [JsonPropertyName("email")]
      public string Email { get; set; }

      [JsonPropertyName("type")]
      public int Type { get; set; }
   }
}