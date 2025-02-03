using PizzaApp.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // Добавление MVC
builder.Services.AddScoped<PizzaRepository>();

var app = builder.Build();

// Настройка маршрутизации
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
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Маршрут по умолчанию

app.Run();