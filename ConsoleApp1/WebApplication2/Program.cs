namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        /**/{
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapControllerRoute("default", pattern: "{controller=first}/{action=index}/{id}");

            app.Run();
        }
    }
}