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
         try
         {
            var model = new Huggy.Models.Flows.Flow()
            {
               Uuid = "1fb9f1bf-242f-4229-a238-6a6d9995af43",
               Variables = new Dictionary<string, string>
               {
                  ["name"] = "Fúlvio Cezar Canducci Dias",
                  ["resume"] = $"Passagem Ida LIS x GRU dia 10/01/2025, Companhia TAP com 3 Passageiros",
                  ["paid"] = "Pago: Entrada de R$ 1000 e 5 boletos de R$ 500",
                  ["boletos"] = "[1] Boleto - https://www.s2milhas.com.br, [2] Boleto - https://www.s2milhas.com.br"
               },
               WhenInAuto = true,
               WhenInChat = true,
               WhenWaitForChat = true
            };
            var result = httpClientHuggy.Flows.PostAsync("422648", "94364563", model).Result;

            Console.WriteLine(result.StatusCode);
            Console.WriteLine(result.Data.ChatID);
            Console.WriteLine(result.Data.Reason);
         }
         catch (Exception)
         {

            throw;
         }

         //var resu = httpClientHuggy.Contacts.GetAsync(94331700).Result;

         //var model = new Huggy.Models.Contacts.ContactUpdate
         //{
         //   Id = "93450618",
         //   Name = "Eduardo Prietro",
         //   Mobile = "5518996132391",
         //   Phone = "5518996132391",
         //   Email = "eduardo@s2viagens.com",
         //   Obs = "Update now super..."
         //};
         //var resultC = httpClientHuggy.Contacts.PutAsync(model, 93450618).Result;

         //var result = httpClientHuggy.Contacts.GetListAsync().Result;
         //if (result.IsValid)
         //{
         //   foreach (var r in result.Data)
         //   {
         //      Console.WriteLine("{0:00000000} - {1} {2} {3}", r.Id, r.Name, r.Phone, r.Mobile);
         //   }
         //}
         //else
         //{
         //   Console.WriteLine("Inválido");
         //}

      }
   }
}
