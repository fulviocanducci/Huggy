using System.Text.Json.Serialization;
namespace Huggy.Models.Contacts
{
   public class Channels
   {
      [JsonPropertyName("voip")]
      public bool Voip { get; set; }

      [JsonPropertyName("messenger")]
      public bool Messenger { get; set; }

      [JsonPropertyName("widget")]
      public bool Widget { get; set; }

      [JsonPropertyName("whatsapp")]
      public bool Whatsapp { get; set; }

      [JsonPropertyName("email")]
      public bool Email { get; set; }

      [JsonPropertyName("sms")]
      public bool Sms { get; set; }

      [JsonPropertyName("telegramBot")]
      public bool TelegramBot { get; set; }

      [JsonPropertyName("whatsappApi")]
      public bool WhatsappApi { get; set; }

      [JsonPropertyName("instagram")]
      public bool Instagram { get; set; }
   }

}
