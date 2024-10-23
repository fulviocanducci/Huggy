using System.Text.Json.Serialization;

namespace Huggy.Models.Flows
{
   // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
   public class FlowReason
   {
      [JsonPropertyName("reason")]
      public string Reason { get; set; }

      [JsonPropertyName("chatID")]
      public int ChatID { get; set; }
   }
}
