using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Huggy.Models.Flows
{
   public class Flow
   {
      public Flow()
      {
         Variables = new Dictionary<string, string>();
      }

      [JsonPropertyName("uuid")]
      public string Uuid { get; set; }

      [JsonPropertyName("variables")]
      public Dictionary<string, string> Variables { get; set; }

      [JsonPropertyName("whenInChat")]
      public bool WhenInChat { get; set; }

      [JsonPropertyName("whenWaitForChat")]
      public bool WhenWaitForChat { get; set; }

      [JsonPropertyName("whenInAuto")]
      public bool WhenInAuto { get; set; }
   }
}
