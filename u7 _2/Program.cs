
using u7.Interfaces; // Para IRepoPersona
using u7.RepoPersona; // <-- ¡Añade esta línea!
var builder = WebApplication.CreateBuilder(args);

//agregado

// Add services to the container.
builder.Services.AddControllersWithViews();


// *** REGISTRO DEL REPOSITORIO ***
// Esto le dice al contenedor de inyección de dependencias que,
// cada vez que un controlador pida IRepoPersona, le debe entregar
// una instancia de RepoPersona (con ciclo de vida Scoped).
// Dentro de Program.cs, antes de app.Run();
// Dentro de Program.cs, antes de app.Run();
builder.Services.AddScoped<IRepoPersona, RepoPersona>();
// *******************************

//end agregado

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();





app.Run();
