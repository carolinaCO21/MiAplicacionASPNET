using u7.Models.Entities;
using u7.Interfaces; // Necesario para implementar la interfaz

namespace u7.RepoPersona
{
    // La clase debe ser pública e implementar la interfaz IRepoPersona.
    public class RepoPersona : IRepoPersona
    {
        /// <summary>
        /// Simula la obtención de un objeto Persona desde una base de datos o fuente de datos.
        /// </summary>
        /// <returns>Una instancia de la entidad Persona.</returns>
        public Persona GetPersonaSimulada()
        {
            // --- SIMULACIÓN DE ACCESO A DATOS ---

            // Usamos el constructor definido en la clase Persona: public Persona(int id, string name, string surname)
            return new Persona(
                id: 1,
                name: "Alex",
                surname: "Gomez"
            );

            // --- FIN DE LA SIMULACIÓN ---
        }
    }
}
