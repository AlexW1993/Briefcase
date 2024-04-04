using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddViewComponentsAsServices();

builder.Services.AddLocalization(options => options.ResourcesPath = "Resource");

builder.Services.AddMvc().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix);

const string defaultCulture = "FR";
var othersCultures = new[]
{
    new CultureInfo(defaultCulture),
    new CultureInfo("EN"),
    new CultureInfo("ES"),
};

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.DefaultRequestCulture = new RequestCulture(defaultCulture);
    options.SupportedCultures = othersCultures;
    options.SupportedUICultures = othersCultures;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    
}

app.UseRequestLocalization(app.Services.GetRequiredService<IOptions<RequestLocalizationOptions>>().Value);

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
