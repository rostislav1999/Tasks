using NLog;
using NLog.Web;
using PizzaApp.Repositories;

var logger = LogManager.Setup().LoadConfigurationFromFile("nlog.config").GetCurrentClassLogger();

try
{
    logger.Debug("Инициализация приложения...");

    var builder = WebApplication.CreateBuilder(args);

    // Настройка NLog
    builder.Logging.ClearProviders(); // Убираем стандартные логгеры
    builder.Logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace); // Устанавливаем минимальный уровень логирования
    builder.Host.UseNLog(); // Интеграция с NLog

    // Добавление сервисов
    builder.Services.AddControllersWithViews();
    builder.Services.AddScoped<PizzaRepository>();

    var app = builder.Build();

    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseRouting();

    app.UseAuthorization();

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    app.Run();
}
catch (Exception ex)
{
    // Логируем ошибки при запуске
    logger.Error(ex, "Приложение завершило работу из-за исключения.");
    throw;
}
finally
{
    // Завершение работы логгера
    LogManager.Shutdown();
}