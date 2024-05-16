using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Projeto.Data;
using System.Globalization;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("ApplicationDbContext") ?? throw new InvalidOperationException("Connection string 'ApplicationDbContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

var locale = "pt-BR";
RequestLocalizationOptions localizationOptions = new RequestLocalizationOptions
{
    SupportedCultures = new List<CultureInfo> { new CultureInfo(locale) },
    SupportedUICultures = new List<CultureInfo> { new CultureInfo(locale) },
    DefaultRequestCulture = new RequestCulture(locale)
};
