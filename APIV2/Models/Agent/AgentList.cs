using System.Text.Json.Serialization;

namespace APIV2.Models.Agent
{
   public class AgentList
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}