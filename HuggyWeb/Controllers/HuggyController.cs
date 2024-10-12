using Huggy;
using Huggy.Models;
using Huggy.Models.Agent;
using Microsoft.AspNetCore.Mvc;

namespace HuggyWeb.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class HuggyController : ControllerBase
   {
      public IHttpClientHuggy HttpClientHuggy { get; }

      public HuggyController(IHttpClientHuggy httpClientHuggy)
      {
         HttpClientHuggy = httpClientHuggy;
      }

      [HttpGet()]
      public async Task<ActionResult> Get()
      {
         IReturnOf<List<AgentList>> result = await HttpClientHuggy.Agent.GetListAsync(null);
         return (result.IsValid) ? Ok(result.Data) : BadRequest(result.Reasons);
      }

      [HttpGet("{id}")]
      public async Task<ActionResult> Get(int id)
      {
         IReturnOf<Agent> result = await HttpClientHuggy.Agent.GetAsync(id);
         return (result.IsValid) ? Ok(result.Data) : BadRequest(result.Reasons);
      }
   }
}
