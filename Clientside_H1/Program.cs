namespace Clientside_H1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            app.UseDefaultFiles();
            app.UseStaticFiles();

            //app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}