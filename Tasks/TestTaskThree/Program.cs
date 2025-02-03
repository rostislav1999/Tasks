using NLog;
using NLog.Web;
using PizzaApp.Repositories;
using Microsoft.EntityFrameworkCore;
using PizzaApp.Models;
using Microsoft.Extensions.FileProviders;

var logger = LogManager.Setup().LoadConfigurationFromFile("nlog.config").GetCurrentClassLogger();

try
{
    logger.Debug("Инициализация приложения...");

    var builder = WebApplication.CreateBuilder(args);

    // Настройка NLog
    builder.Logging.ClearProviders();
    builder.Logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
    builder.Host.UseNLog();

    // Добавление сервисов
    builder.Services.AddControllersWithViews();

    // Регистрация контекста БД
    builder.Services.AddDbContext<PizzaDBContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("PizzaDBConnection")));

    // Регистрация репозитория
    builder.Services.AddScoped<PizzaRepository>();

    var app = builder.Build();

    // Настройка конвейера HTTP-запросов
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
        app.UseHsts();
    }

    app.UseHttpsRedirection();

    // Настройка статических файлов
    app.UseStaticFiles(new StaticFileOptions
    {
        FileProvider = new PhysicalFileProvider(
            Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img")),
        RequestPath = "/img",
        OnPrepareResponse = ctx =>
        {
            ctx.Context.Response.Headers.Append("Cache-Control", "public,max-age=604800");
        }
    });

    app.UseRouting();
    app.UseAuthorization();

    // Маршрутизация
    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    logger.Info("Приложение успешно запущено");
    app.Run();
}
catch (Exception ex)
{
    logger.Error(ex, "Приложение завершило работу из-за исключения.");
    throw;
}
finally
{
    LogManager.Shutdown();
}