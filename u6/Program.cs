using u6.Services; // NUEVO �Aseg�rate de incluir este using!

//plantilla ----
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();
//plantilla ----


// ----------------------------------------------------------------
// NUEVO
// AQU� REGISTRAMOS EL SERVICIO PARA QUE DI LO CONOZCA
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
 * �Qu� es?
 * Esto es el registro de un servicio en el Contenedor de Inyecci�n de Dependencias (DI) de ASP.NET Core.
 * Prop�sito
 * Le indica al runtime de ASP.NET Core c�mo debe crear y administrar las instancias de la clase
 * TablaMultiplicacionService cuando otra clase (como el HomeController) las solicite. Esto
 * implementa el Principio de Inversi�n de Dependencias (DIP) de SOLID.
 * 
 * Explicaci�n
 * builder.Services (El Contenedor DI)
 * En .NET Core, builder.Services es una colecci�n que representa el Contenedor de Servicios
 * (o Contenedor DI). Aqu� es donde se registran todas las clases que actuar�n como servicios o dependencias
 * 
 * AddTransient<TService>() (El Ciclo de Vida)
 * AddTransient es uno de los tres principales ciclos de vida que puedes asignar a un servicio. 
 * 
 * Un ciclo de vida define cu�ndo se crea la instancia del servicio:
 * 
 * AddTransient: Crea una nueva instancia de la clase de servicio cada vez que se solicita.
 *      Ejemplo: Es ideal para servicios ligeros o aquellos que realizan una sola operaci�n y no tienen estado 
 *      (como tu TablaMultiplicacionService que solo calcula la tabla).
 * 
 * AddScoped: Crea una instancia por cada petici�n HTTP (cada vez que un usuario pide una p�gina). 
 * Si se solicita m�ltiples veces dentro de la misma petici�n, obtendr� la misma instancia.
 *      Ejemplo: Es com�n para servicios que interact�an con bases de datos (repositorios o unidades de trabajo).
 * 
 * AddSingleton: Crea una �nica instancia de la clase de servicio para toda la vida de la aplicaci�n 
 * (desde que se inicia hasta que se detiene).
 *      Ejemplo: Es �til para servicios de configuraci�n, logging (registro de eventos) o cach�s que deben ser 
 *      compartidas globalmente.
 *      
 * El Resultado
 *  Al escribir builder.Services.AddTransient<TablaMultiplicacionService>();, est�s diciendo:
 *  "Hey Contenedor DI, por favor, registra la clase TablaMultiplicacionService. De ahora en adelante, 
 *  cada vez que una clase (como HomeController) la pida en su constructor, crea una instancia nueva de ella 
 *  y sumin�strala (Transient)."
 *  Si no haces este registro, el Contenedor DI no tiene instrucciones y por eso arroja la excepci�n: 
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