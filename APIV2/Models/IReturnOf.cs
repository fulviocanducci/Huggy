using System.Collections.Generic;

namespace Huggy.Models
{
   public interface IReturnOf<T>
   {
      T Data { get; }
      Dictionary<string, string> Reasons { get; }
      string Reason { get; }
      int StatusCode { get; }
      bool IsValid { get; }
   }
}