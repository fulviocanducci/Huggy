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

      public Flow(string uuid)
      {
         Variables = new Dictionary<string, string>();
         Uuid = uuid;
      }

      [JsonPropertyName("uuid")]
      public string Uuid { get; set; }

      [JsonPropertyName("variables")]
      public Dictionary<string, string> Variables { get; set; }

      [JsonPropertyName("whenInChat")]
      public bool WhenInChat { get; set; } = true;

      [JsonPropertyName("whenWaitForChat")]
      public bool WhenWaitForChat { get; set; } = true;

      [JsonPropertyName("whenInAuto")]
      public bool WhenInAuto { get; set; } = true;

      public Flow AddVariable(string name, string value)
      {
         Variables.Add(name, value);
         return this;
      }
      public Flow AddVariables(IEnumerable<FlowItem> items)
      {
         foreach (var item in items)
         {
            Variables.Add(item.Name, item.Value);
         }
         return this;
      }
      public static Flow Create(string uuid) => new Flow(uuid);
   }
}
