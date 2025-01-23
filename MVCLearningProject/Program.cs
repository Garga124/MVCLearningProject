using Microsoft.AspNetCore.Mvc.Formatters;
using System.Net.Mime;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern:"{controller=Home}/{action=Index}/{id?}");




app.Run();

