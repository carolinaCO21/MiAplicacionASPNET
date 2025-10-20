using System.Runtime.CompilerServices;

namespace u7.Models.Entities
{
    public class Persona
    {
        // Propiedad de Solo Lectura (Solo se puede asignar en el constructor o en la inicialización)
        public int Id { get; init; }

        // Propiedades Autoimplementadas (Elimina los campos privados y los getters/setters manuales)
        public string Name { get; set; }
        public string Surname { get; set; }

        // Constructor por defecto (Corregido el error de escritura)
        public Persona()
        {
            // Opcional: inicialización de propiedades aquí si no se hace arriba
        }


        public Persona(string name, string surname)
        {

            this.Name = name;
            this.Surname = surname;
        }
    }
 
}