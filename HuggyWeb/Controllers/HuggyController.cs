using Huggy;
using Huggy.Models;
using Huggy.Models.Agent;
using Huggy.Models.Contacts;
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
         IReturnOf<List<AgentList>> result = await HttpClientHuggy.Agents.GetListAsync(null);
         return (result.IsValid) ? Ok(result.Data) : BadRequest(result.Reasons);
      }

      [HttpGet("{id}")]
      public async Task<ActionResult> Get(int id)
      {
         IReturnOf<Agent> result = await HttpClientHuggy.Agents.GetAsync(id);
         return (result.IsValid) ? Ok(result.Data) : BadRequest(result.Reasons);
      }

      [HttpGet("/contacts")]
      public async Task<ActionResult> GetContacts()
      {
         ContactCreate model = new ContactCreate
         {
            Name = "Claudio Luiz",
            Mobile = "5518996279731",
            Phone = "5518996279731",
            Email = "claudio.s2milhas@gmail.com",
         };
         IReturnOf<Contact> result = await HttpClientHuggy.Contacts.PostAsync(model);
         return (result.IsValid) ? Ok(result.Data) : BadRequest(result.Reasons);
      }
   }
}
