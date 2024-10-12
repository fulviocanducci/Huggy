using Huggy;
using Huggy.Configurations;
using Huggy.Models;
using Huggy.Models.Agent;

namespace HuggyConsole
{
   internal class Program
   {
      static void Main(string[] args)
      {
         IConfigurationHuggy configurationHuggy = new ConfigurationHuggy("application/json", "application/json", "be27e5d6a162ca3fca295aabc5946106");
         IHttpClientHuggy httpClientHuggy = new HttpClientHuggy(new HttpClient(), configurationHuggy);
         IReturnOf<Agent> resultById = httpClientHuggy.Agent.GetAsync(153603).Result;
         IReturnOf<List<AgentList>> resultList = httpClientHuggy.Agent.GetListAsync().Result;

         Console.WriteLine("Hello, World!");
      }
   }
}
