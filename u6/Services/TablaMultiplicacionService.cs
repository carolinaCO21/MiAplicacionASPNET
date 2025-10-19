using u6.Models; // Referencia a nuestro "Dominio"
using System.Collections.Generic;


namespace u6.Services
{
    public class TablaMultiplicacionService
    {
        // SOLID: Principio de Responsabilidad Única (SRP)
        // Solo se encarga de generar la tabla.
       
        private const int MinFactor = 1;
        private const int MaxFactor = 12;

        public List<List<FilaMultiplicacion>> GenerarTabla()
        {
            var tabla = new List<List<FilaMultiplicacion>>();

            for (int f1 = MinFactor; f1 <= MaxFactor; f1++)
            {
                var columna = new List<FilaMultiplicacion>();
                for (int f2 = MinFactor; f2 <= MaxFactor; f2++)
                {
                    columna.Add(new FilaMultiplicacion(f1, f2));
                }
                tabla.Add(columna);
            }

            return tabla;
        }



        }


}
