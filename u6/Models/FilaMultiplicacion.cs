namespace u6.Models
{
    // SRP: Solo representa el dato.
    public class FilaMultiplicacion
    {
        public int Factor1 { get; }
        public int Factor2 { get; }
        public int Resultado { get; }

        public FilaMultiplicacion(int factor1, int factor2)
        {
            Factor1 = factor1;
            Factor2 = factor2;
            Resultado = factor1 * factor2;
        }

        public override string ToString()
        {
            return $"{Factor1} * {Factor2} = {Resultado}";
        }
    }
}

