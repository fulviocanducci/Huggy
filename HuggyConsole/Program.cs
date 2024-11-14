using Huggy;
using Huggy.Configurations;
using Huggy.Models.Flows;
using iText.IO.Image;
using iText.Kernel.Events;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
namespace HuggyConsole
{
   internal class Program
   {
      static void Main(string[] args)
      {
         IConfigurationHuggy configurationHuggy = new ConfigurationHuggy("application/json", "*/*", "be27e5d6a162ca3fca295aabc59461**", "1fb9f1bf-242f-4229-a238-6a6d9995af43");
         IHttpClientHuggy httpClientHuggy = new HttpClientHuggy(new HttpClient(), configurationHuggy);
         //IReturnOf<Agent> resultById = httpClientHuggy.Agents.GetAsync(153603).Result;
         //IReturnOf<List<AgentList>> resultList = httpClientHuggy.Agent.GetListAsync().Result;
         try
         {
            //Flow flow = httpClientHuggy.CreateFlow();
            //flow.Variables.Add("usersellername", "vendedor");
            //flow.Variables.Add("orderid", "100");
            //flow.Variables.Add("clientname", "Eu porra");

            //422648


            //var result = httpClientHuggy
            //   .Flows.SendAsync("422496", "94706397", flow)
            //   .Result;

            Flow flow = httpClientHuggy.CreateFlow();
            //flow.AddVariable("name", "Fúlvio Cezar Canducci Dias");
            //flow.AddVariable("datepay", "05/11/2024");
            //flow.AddVariable("value", "R$ 2.560,00");
            //flow.AddVariable("link", "https://www.s2viagens.com");
            var c = httpClientHuggy.Flows.SendAsync("424373", "95398834", flow).Result;
            //var flowReason = httpClientHuggy.Flows.SendAsync("425376", "95398834", flow).Result;

            int ai = 0;


            //Flow flowA = httpClientHuggy.CreateFlow();
            //flowA.Variables.Add("name", "Souzaa");
            //var resultA = httpClientHuggy.Flows.SendAsync("422482", "94706397", flowA).Result;
            //var c = 10;


            //   Console.WriteLine(result.StatusCode);
            //   Console.WriteLine(result.Data.ChatID);
            //   Console.WriteLine(result.Data.Reason);
            //}
            //catch (Exception)
            //{

            //   throw;
            //}



            //ContactUpdate modelUpdate = new Huggy.Models.Contacts.ContactUpdate
            //{
            //   Name = "Eduardo Prietro",
            //   Mobile = "5518996132391",
            //   Phone = "5518996132391",
            //   Email = "eduardo@s2viagens.com",
            //   Obs = "",
            //   Id = "93450618"
            //};
            ////var resultC = httpClientHuggy.Contacts.AddAsync(modelCreate).Result;
            //var resultD = httpClientHuggy.Contacts.UpdateAsync(modelUpdate, modelUpdate.Id).Result;
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

            //string pdfPath = @"c:\Temp\exemplo.pdf";
            //if (File.Exists(pdfPath))
            //{
            //   File.Delete(pdfPath);
            //}
            //// Crie um novo documento PDF
            //using (PdfWriter writer = new PdfWriter(pdfPath))
            //using (PdfDocument pdf = new PdfDocument(writer))
            //{
            //   Document document = new Document(pdf);

            //   document.Add(new Paragraph("Olá, Fúlvio").SetMarginTop(80));

            //   document.Add(new Paragraph("Departamento Financeiro da S2 Milhas e Viagens.")
            //      .SetTextAlignment(TextAlignment.CENTER));

            //   document.Add(new Paragraph("Resumo do Contrato")
            //      .SetTextAlignment(TextAlignment.CENTER)
            //      .SetBold()
            //      .SetBorder(new SolidBorder(1)));

            //   document.Add(new Paragraph("Passagem Ida LIS x GRU dia 10/01/2025, Companhia TAP com 3 Passageiros")
            //      .SetTextAlignment(TextAlignment.LEFT));

            //   document.Add(new Paragraph("Pago: Entrada de R$ 1000 e 5 boletos de R$ 500")
            //      .SetTextAlignment(TextAlignment.LEFT));

            //   document.Add(new Paragraph("Boletos")
            //      .SetTextAlignment(TextAlignment.CENTER)
            //      .SetBold()
            //      .SetBorder(new SolidBorder(1)));

            //   document.Add(new Paragraph("[1] Boleto - https://www.s2milhas.com.br")
            //      .SetTextAlignment(TextAlignment.LEFT));
            //   document.Add(new Paragraph("[2] Boleto - https://www.s2milhas.com.br")
            //      .SetTextAlignment(TextAlignment.LEFT));
            //   document.Add(new Paragraph("[3] Boleto - https://www.s2milhas.com.br")
            //      .SetTextAlignment(TextAlignment.LEFT));

            //Table table = new Table(3, true);

            //// Adicione cabeçalhos
            //table.AddHeaderCell("Coluna 2");
            //table.AddHeaderCell("Coluna 2");
            //table.AddHeaderCell("Coluna 3");

            //// Adicione algumas linhas de dados
            //for (int i = 1; i <= 5; i++)
            //{
            //   table.AddCell($"Linha {i}, Coluna 1");
            //   table.AddCell($"Linha {i}, Coluna 2");
            //   table.AddCell($"Linha {i}, Coluna 3");
            //}

            //// Adicione a tabela ao documento
            //document.Add(table);

            // Finalize o documento            

            //   pdf.AddEventHandler(PdfDocumentEvent.END_PAGE, new FooterEventHandler(@"c:\temp\logo-curto-s2-100x100.png"));

            //   document.Close();
            //}

            //Console.WriteLine($"PDF gerado em: {Path.GetFullPath(pdfPath)}");
         }
         finally
         {

         }
      }
      public class FooterEventHandler : IEventHandler
      {
         private string _imagePath { get; }
         public FooterEventHandler(string imagePath)
         {
            _imagePath = imagePath;
         }

         public void HandleEvent(Event evt)
         {
            PdfDocumentEvent docEvent = (PdfDocumentEvent)evt;
            PdfPage page = docEvent.GetPage();
            PdfCanvas canvas = new PdfCanvas(page);

            // Adicionar cabeçalho (imagem)
            if (File.Exists(_imagePath))
            {
               ImageData image = iText.IO.Image.ImageDataFactory.Create(_imagePath);
               float width = image.GetWidth();
               float height = image.GetHeight();
               float x1 = (page.GetPageSize().GetWidth() - width) / 2; // Centraliza a imagem
               float y1 = page.GetPageSize().GetHeight() - height - 20; // Posição do cabeçalho

               canvas.AddImageAt(image, x1, y1, false);

            }



            // Defina o conteúdo do rodapé
            var eventPages = docEvent.GetDocument();
            int pageTotal = eventPages.GetNumberOfPages();
            int pageNumber = eventPages.GetPageNumber(page);
            string footerText = $"Página {pageNumber}/{pageTotal}";

            // Adicione o rodapé na parte inferior da página
            float x = page.GetPageSize().GetWidth() / 2;
            float y = 30; // Distância do fundo

            canvas.BeginText();
            canvas.SetFontAndSize(iText.Kernel.Font.PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFonts.HELVETICA), 10);
            canvas.SetTextMatrix(x, y);
            canvas.ShowText(footerText);
            canvas.EndText();
         }
      }
   }
}
