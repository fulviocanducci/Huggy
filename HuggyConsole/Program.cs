using Huggy;
using Huggy.Configurations;

namespace HuggyConsole
{
   internal class Program
   {
      static void Main(string[] args)
      {
         IConfigurationHuggy configurationHuggy = new ConfigurationHuggy("application/json", "*/*", "be27e5d6a162ca3fca295aabc5946106");
         IHttpClientHuggy httpClientHuggy = new HttpClientHuggy(new HttpClient(), configurationHuggy);
         //IReturnOf<Agent> resultById = httpClientHuggy.Agent.GetAsync(153603).Result;
         //IReturnOf<List<AgentList>> resultList = httpClientHuggy.Agent.GetListAsync().Result;
         //try
         //{
         //   var model = new Huggy.Models.Flows.Flow()
         //   {
         //      Uuid = "1fb9f1bf-242f-4229-a238-6a6d9995af43",
         //      Variables = new Dictionary<string, string>
         //      {
         //         ["link"] = "https://www.s2milhas.com.br",
         //         ["name"] = "Fúlvio Cezar Canducci Dias"
         //      },
         //      WhenInAuto = true,
         //      WhenInChat = true,
         //      WhenWaitForChat = true
         //   };
         //   var result = httpClientHuggy.Flows.PostAsync("422482", "94331700", model).Result;

         //   Console.WriteLine(result.StatusCode);
         //   Console.WriteLine(result.Data.ChatID);
         //   Console.WriteLine(result.Data.Reason);
         //}
         //catch (Exception)
         //{

         //   throw;
         //}

         //var resu = httpClientHuggy.Contacts.GetAsync(94331700).Result;

         var model = new Huggy.Models.Contacts.ContactCreate
         {
            Name = "Claudio Luiz",
            Mobile = "5518996279731",
            Phone = "5518996279731",
            Email = "claudio.s2milhas@gmail.com",
         };
         var resultC = httpClientHuggy.Contacts.PostAsync(model).Result;

         var result = httpClientHuggy.Contacts.GetListAsync().Result;
         if (result.IsValid)
         {
            foreach (var r in result.Data)
            {
               Console.WriteLine("{0:00000000} - {1} {2} {3}", r.Id, r.Name, r.Phone, r.Mobile);
            }
         }
         else
         {
            Console.WriteLine("Inválido");
         }

      }
   }
}
