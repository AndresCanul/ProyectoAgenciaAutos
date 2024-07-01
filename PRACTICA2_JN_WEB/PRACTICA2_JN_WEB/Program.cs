using PRACTICA2_JN_WEB.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient();
builder.Services.AddScoped<IVendedorModel, VendedorModel>();
builder.Services.AddScoped<IVehiculoModel, VehiculoModel>();

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
    pattern: "{controller=Inicio}/{action=PantallaPrincipal}/{id?}");

app.Run();
