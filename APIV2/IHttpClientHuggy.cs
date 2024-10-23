using Huggy.Https;

namespace Huggy
{
   public interface IHttpClientHuggy
   {
      IAgentHttp Agent { get; }
      IFlowsHttp Flows { get; }
   }
}