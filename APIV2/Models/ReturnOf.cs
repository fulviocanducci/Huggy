using System.Collections.Generic;

namespace Huggy.Models
{
   public class ReturnOf<T> : IReturnOf<T>
   {
      public string Reason { get; }
      public Dictionary<string, string> Reasons { get; }
      public int StatusCode { get; }
      public T Data { get; }
      public bool IsValid
      {
         get
         {
            return StatusCode >= 200 && StatusCode <= 299;
         }
      }

      public ReturnOf(int statusCode, T data)
      {
         Reasons = new Dictionary<string, string>();
         StatusCode = statusCode;
         Data = data;
         Reasons.Clear();
      }

      public ReturnOf(int statusCode, string reason)
      {
         Reasons = new Dictionary<string, string>();
         StatusCode = statusCode;
         Reason = reason;
         Reasons.Add("Error", reason);
      }

      public static ReturnOf<T> CreateSuccessStatusCode(int statusCode, T data)
         => new ReturnOf<T>(statusCode, data);

      public static ReturnOf<T> CreateErrorStatusCode(int statusCode, string reason)
         => new ReturnOf<T>(statusCode, reason);
   }
}
