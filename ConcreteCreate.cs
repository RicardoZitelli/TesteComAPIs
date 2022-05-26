namespace SoftPlan
{
    public class ConcreteCreate : ICreate
    {
        public Financa CriarObjeto()
        {
            return new Financa();
        }
    }
}
