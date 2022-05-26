using TesteComAPIs.Interfaces;

namespace SoftPlan
{
    public class Fabrica : IFabrica
    {
        public Financa CriarObjetoFinanca()
        {
            return new Financa();
        }
    }
}
