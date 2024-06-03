using Microsoft.EntityFrameworkCore;
using CrudNet8MVC.Data;

var builder = WebApplication.CreateBuilder(args); 


//Configuramos la conexion a sql ser local db MSSQLLOCAL
builder.Services.AddDbContext<AplicationDbContext>(opciones =>
        opciones.UseSqlServer(builder.Configuration.GetConnectionString("ConexionSQL")));


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Inicio}/{action=Index}/{id?}");

app.Run();
