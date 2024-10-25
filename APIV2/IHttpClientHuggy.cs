using Huggy.Https;
using Huggy.Models.Flows;

namespace Huggy
{
   public interface IHttpClientHuggy
   {
      IAgentHttp Agents { get; }
      IFlowsHttp Flows { get; }
      IContactHttp Contacts { get; }
      Flow CreateFlow();
      string Uuid { get; }
   }
}