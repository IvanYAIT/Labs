namespace DecoratorTest
{
    public abstract class Decorator : BaseClass
    {
        protected BaseClass someObject;

        public Decorator(int a, BaseClass someObject) : base(a)
        {
            this.someObject = someObject;
        }

    }

    public class DecoratorA : Decorator
    {
        public DecoratorA(int a, BaseClass someObject) : base(a, someObject)
        {
        }

        public override float GetSmth()
        {
            return someObject.GetSmth() * 5;
        }
    }
}