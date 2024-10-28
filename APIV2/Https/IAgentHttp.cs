using Huggy.Models;
using Huggy.Models.Agent;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Huggy.Https
{
   public interface IAgentHttp
   {
      Task<IReturnOf<List<AgentList>>> ListAsync(int? page = null);
      Task<IReturnOf<Agent>> GetAsync(int id);
      Task AddAsync(AgentCreate model);
      Task AddAsync(string email, int type);
      Task<IReturnOf<Agent>> UpdateAsync(Agent model, int id);
   }
}