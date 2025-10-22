using u7.Models.Entities; // Asume que tu entidad Persona está aquí

namespace u7.Models.ViewModels
{
    public class PersonaViewModel
    {

        /*
        // Propiedad 1: Almacena el saludo dinámico (string)
        public string Saludo { get; set; }

        // Propiedad 2: Almacena la fecha actual formateada (string)
        public string FechaActual { get; set; }

        */

        // Propiedad 3: Almacena la entidad Persona completa
        // Esta es la propiedad que se usa para acceder a Id, Name, Surname, etc.
        public Persona DatosPersona { get; set; }
    }
}