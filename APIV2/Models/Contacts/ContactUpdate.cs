using System.Text.Json.Serialization;
namespace Huggy.Models.Contacts
{
   public class ContactUpdate : ContactCreate
   {
      [JsonPropertyName("id")]
      public string Id { get; set; }
   }

}
