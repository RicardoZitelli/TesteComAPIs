namespace SoftPlan
{
    public class Financa:IFinanca
    {     
       
        public IFinanca Criar()
        {
            return new Financa();
        }
        public decimal RetornarTaxaDeJuros(decimal valor)
        {
            try
            {                
                return valor * 0.01M;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public decimal CalcularJuros(decimal valorInicial, decimal juros, int meses)
        {
            try
            {
                return valorInicial * Math.Pow(1M + juros, meses);
            }
            catch (Exception)
            {

                return 0;
            }
            
        }




    }
}
