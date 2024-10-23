using Huggy.Https;

namespace Huggy
{
   public interface IHttpClientHuggy
   {
      IAgentHttp Agents { get; }
      IFlowsHttp Flows { get; }
      IContactHttp Contacts { get; }
   }
}