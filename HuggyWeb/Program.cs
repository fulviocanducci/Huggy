namespace HuggyWeb
{
   public class Program
   {
      public static void Main(string[] args)
      {
         WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
         builder.Services.AddControllers();
         builder.Services.Configure<RouteOptions>(options =>
         {
            options.LowercaseUrls = true;
            options.LowercaseQueryStrings = true;
         });
         builder.Services.AddEndpointsApiExplorer();
         builder.Services.AddSwaggerGen();
         builder.Services.AddHttpClient();
         //builder.Services.AddHuggy(builder.Configuration);
         WebApplication app = builder.Build();
         if (app.Environment.IsDevelopment())
         {
            app.UseSwagger();
            app.UseSwaggerUI();
         }
         app.UseHttpsRedirection();
         app.UseAuthorization();
         app.MapControllers();
         app.Run();
      }
   }
}