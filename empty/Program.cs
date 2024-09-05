using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.DependencyInjection;

namespace empty;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();//ajoute les services
        // pour les controlleurs et les vues
        var app = builder.Build();
        app.UseStaticFiles();//ajoute le midleware pour les fichiers
        app.UseRouting();//ajoute le midleware pour le routage
        //ajoute le routing par defaut pour les controlleur
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
        app.Run();
    }
}
