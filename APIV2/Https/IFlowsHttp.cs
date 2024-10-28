using Huggy.Models;
using Huggy.Models.Flows;
using System.Threading.Tasks;
namespace Huggy.Https
{
   public interface IFlowsHttp
   {
      Task<IReturnOf<FlowReason>> SendAsync(string flowId, string contactId, Flow model);
   }
}