using BankManagement.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc;
using BankManagement.Services;
using Microsoft.AspNetCore.Http;
using BankManagement.Middlewares;

namespace BankManagement;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews();

        builder.Services.AddHttpContextAccessor();
        builder.Services.AddDistributedMemoryCache();
        builder.Services.AddSession(Options =>
        {
            Options.IdleTimeout = TimeSpan.FromSeconds(100);
            Options.Cookie.HttpOnly = true;
            Options.Cookie.IsEssential = true;
        });
        builder.Services.AddSingleton<Log>();
        builder.Services.AddSingleton<IUserService, UserService>();
        builder.Services.AddSingleton<IUserRepository, UserRepository>();


        var app = builder.Build();


        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
        }
        app.UseStaticFiles();

        app.UseLogger();

        app.UseRouting();
        app.UseAuthorization();
        app.UseSession();
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=home}/{action=index}/{id?}");

        app.Run();
    }
}

