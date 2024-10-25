﻿using System.Text.Json.Serialization;

namespace Huggy.Models.Agent
{
   public abstract class AgentBase<T>
   {
      [JsonPropertyName("id")]
      public T Id { get; set; }

      [JsonPropertyName("name")]
      public string Name { get; set; }
   }
}
