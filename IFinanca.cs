namespace SoftPlan
{
    public interface IFinanca
    {
        public decimal RetornarTaxaDeJuros(decimal valor);
        public decimal CalcularJuros(decimal valorInicial, decimal juros, int meses);
    }
}
