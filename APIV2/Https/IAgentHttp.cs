using Huggy.Models;
using Huggy.Models.Agent;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Huggy.Https
{
   public interface IAgentHttp
   {
      Task<IReturnOf<List<AgentList>>> GetListAsync(int? page = null);
      Task<IReturnOf<Agent>> GetAsync(int id);
      Task PostAsync(AgentCreate model);
      Task PostAsync(string email, int type);
      Task<IReturnOf<Agent>> PutAsync(Agent model, int id);
   }
}