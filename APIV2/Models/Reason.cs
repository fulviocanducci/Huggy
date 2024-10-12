using System.Text.Json.Serialization;

namespace APIV2.Models
{
   public sealed class ReasonResult
   {
      [JsonPropertyName("reason")]
      public string Reason { get; set; }
   }
}
