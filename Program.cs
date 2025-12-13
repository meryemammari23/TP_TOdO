using TP_TODO.Services;
using TP_TODO_V1.Filters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add<ThemeFilter>();
});

builder.Services.AddSession();

builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped<ICookieManagerService, CookieManagerService>();
builder.Services.AddScoped<ISessionManagerService, SessionManagerService>();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Todo}/{action=Index}/{id?}");

app.Run();
