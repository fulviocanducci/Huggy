﻿using APIV2.Models;
using APIV2.Models.Agent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIV2.Https
{
   public interface IAgentHttp
   {
      Task<IReturnOf<List<AgentList>>> GetListAsync(int? page = null);
      Task<IReturnOf<Agent>> GetAsync(int id);
   }
}