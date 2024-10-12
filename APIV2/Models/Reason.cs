using System.Text.Json.Serialization;

namespace Huggy.Models
{
   public sealed class ReasonResult
   {
      [JsonPropertyName("reason")]
      public string Reason { get; set; }
   }
}
