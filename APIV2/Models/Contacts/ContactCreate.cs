using System.Text.Json.Serialization;
namespace Huggy.Models.Contacts
{
   public class ContactCreate
   {
      [JsonPropertyName("name")]
      public string Name { get; set; }

      [JsonPropertyName("phone")]
      public string Phone { get; set; }

      [JsonPropertyName("mobile")]
      public string Mobile { get; set; }

      [JsonPropertyName("email")]
      public string Email { get; set; }
   }
}
