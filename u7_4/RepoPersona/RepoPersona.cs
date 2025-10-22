using u7_4.Models.Entities;

namespace u7_4.RepoPersona
{
    public class RepoPersona
    {
        public  static List<Persona> personas;
        /// <summary>
        /// Simula la obtención de un objeto Persona desde una base de datos o fuente de datos.
        /// </summary>
        /// <returns>Una instancia de la entidad Persona.</returns>

        


        public static List<Persona> GetPersonas() {

            return personas;
        }

        public static Persona getPersonaByPosition(int position) { 

            return personas[position];

        }


    }
}
