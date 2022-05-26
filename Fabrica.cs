using TesteComAPIs.Interfaces;

namespace SoftPlan
{
    public class Fabrica : IFabrica
    {
        public Financa CriarObjeto()
        {
            return new Financa();
        }
    }
}
