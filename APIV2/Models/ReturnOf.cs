namespace Huggy.Models
{
   public class ReturnOf<T> : IReturnOf<T>
   {
      public string Reason { get; }
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
         StatusCode = statusCode;
         Data = data;
      }

      public ReturnOf(int statusCode, string reason)
      {
         StatusCode = statusCode;
         Reason = reason;
      }

      public static ReturnOf<T> CreateSuccessStatusCode(int statusCode, T data)
         => new ReturnOf<T>(statusCode, data);

      public static ReturnOf<T> CreateErrorStatusCode(int statusCode, string reason)
         => new ReturnOf<T>(statusCode, reason);
   }
}
