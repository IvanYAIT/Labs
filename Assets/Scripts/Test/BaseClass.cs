namespace DecoratorTest
{
    public abstract class BaseClass
    {
        public int A { get; protected set; }

        public BaseClass(int a)
        {
            A = a;
        }

        public abstract float GetSmth();
    }

    public class ObjectA : BaseClass
    {
        public ObjectA(int a) : base(a) { }

        public override float GetSmth() => .5f;
    }
}