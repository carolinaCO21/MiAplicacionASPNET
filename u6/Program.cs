using u6.Services; // NUEVO ¡Asegúrate de incluir este using!

//plantilla ----
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();
//plantilla ----


// ----------------------------------------------------------------
// NUEVO
// AQUÍ REGISTRAMOS EL SERVICIO PARA QUE DI LO CONOZCA
// ----------------------------------------------------------------
// Registramos el TablaMultiplicacionService como Transient.
// Esto soluciona el error "Unable to resolve service".
builder.Services.AddTransient<TablaMultiplicacionService>();
// ----------------------------------------------------------------


//plantilla ----
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// lo vamos a tocar
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
//plantilla ----



/**
 * builder.Services.AddTransient<TablaMultiplicacionService>();
 * ¿Qué es?
 * Esto es el registro de un servicio en el Contenedor de Inyección de Dependencias (DI) de ASP.NET Core.
 * Propósito
 * Le indica al runtime de ASP.NET Core cómo debe crear y administrar las instancias de la clase
 * TablaMultiplicacionService cuando otra clase (como el HomeController) las solicite. Esto
 * implementa el Principio de Inversión de Dependencias (DIP) de SOLID.
 * 
 * Explicación
 * builder.Services (El Contenedor DI)
 * En .NET Core, builder.Services es una colección que representa el Contenedor de Servicios
 * (o Contenedor DI). Aquí es donde se registran todas las clases que actuarán como servicios o dependencias
 * 
 * AddTransient<TService>() (El Ciclo de Vida)
 * AddTransient es uno de los tres principales ciclos de vida que puedes asignar a un servicio. 
 * 
 * Un ciclo de vida define cuándo se crea la instancia del servicio:
 * 
 * AddTransient: Crea una nueva instancia de la clase de servicio cada vez que se solicita.
 *      Ejemplo: Es ideal para servicios ligeros o aquellos que realizan una sola operación y no tienen estado 
 *      (como tu TablaMultiplicacionService que solo calcula la tabla).
 * 
 * AddScoped: Crea una instancia por cada petición HTTP (cada vez que un usuario pide una página). 
 * Si se solicita múltiples veces dentro de la misma petición, obtendrá la misma instancia.
 *      Ejemplo: Es común para servicios que interactúan con bases de datos (repositorios o unidades de trabajo).
 * 
 * AddSingleton: Crea una única instancia de la clase de servicio para toda la vida de la aplicación 
 * (desde que se inicia hasta que se detiene).
 *      Ejemplo: Es útil para servicios de configuración, logging (registro de eventos) o cachés que deben ser 
 *      compartidas globalmente.
 *      
 * El Resultado
 *  Al escribir builder.Services.AddTransient<TablaMultiplicacionService>();, estás diciendo:
 *  "Hey Contenedor DI, por favor, registra la clase TablaMultiplicacionService. De ahora en adelante, 
 *  cada vez que una clase (como HomeController) la pida en su constructor, crea una instancia nueva de ella 
 *  y suminístrala (Transient)."
 *  Si no haces este registro, el Contenedor DI no tiene instrucciones y por eso arroja la excepción: 
 *  Unable to resolve service (No puedo resolver el servicio), que es lo que viste en el error de la imagen.
 */




// PLANTILLA

/*
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
*/