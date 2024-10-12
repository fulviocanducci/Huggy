namespace APIV2.Models
{
   public interface IReturnOf<T>
   {
      T Data { get; }
      string Reason { get; }
      int StatusCode { get; }
   }
}