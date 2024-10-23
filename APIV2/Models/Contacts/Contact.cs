using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace Huggy.Models.Contacts
{
   public class Contact
   {
      [JsonPropertyName("id")]
      public int Id { get; set; }

      [JsonPropertyName("name")]
      public string Name { get; set; }

      [JsonPropertyName("email")]
      public string Email { get; set; }

      [JsonPropertyName("mobile")]
      public string Mobile { get; set; }

      [JsonPropertyName("phone")]
      public string Phone { get; set; }

      [JsonPropertyName("birthday")]
      public object Birthday { get; set; }

      [JsonPropertyName("customFields")]
      public Dictionary<string, object> CustomFields { get; set; }

      [JsonPropertyName("channels")]
      public Channels Channels { get; set; }
   }

}
