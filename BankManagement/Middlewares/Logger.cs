using BankManagement.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using System.ComponentModel.Design;
using System.Threading.Tasks;

namespace BankManagement.Middlewares;

public class Logger
{
    private readonly Log _log;
    private readonly RequestDelegate _next;
    public Logger(RequestDelegate next, Log log)
    {
        _log = log;
        _next = next;
    }

    public Task Invoke(HttpContext context)
    {
        var url = context.Request.Path.ToString();
        if (url.Contains("Deposit") || url.Contains("Payment"))
        {
            _log.date = DateTime.Now;
            _log.url = context.Request.Path;
            _log.ResultStatusCode = context.Response.StatusCode;
            var FilePath = @"C:\logfile.txt";
            using (TextWriter tw = File.AppendText(FilePath))
            {
                tw.WriteLine($"Date: {_log.date},Url: {_log.url},StatusCode: {_log.ResultStatusCode}");
            }
        }
        return _next(context);
    }
}

public static class LoggerExtension
{
    public static IApplicationBuilder UseLogger(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<Logger>();
    }
}

//app.Use(async (ctx, next) =>
//{
//    var log = new Log()
//    {
//        Timespan = DateTime.Now,
//        Url = ctx.Request.Path,
//        Resultstatuscode = ctx.Response.StatusCode
//    };
//var Filepath = @"D:\Test\logfile.txt";
//    using(var writer = File.AppendText(Filepath))
//    {
//        writer.WriteLine($"Timestamp:{log.Timespan},Url:{log.Url},Statuscode:{log.Resultstatuscode}");
//    }
//    await next();
//});
