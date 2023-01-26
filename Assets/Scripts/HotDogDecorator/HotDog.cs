namespace HotDog
{
    public abstract class HotDog
    {
        public HotDogData HotDogData { get; protected set; }

        protected HotDog(HotDogData hotDogData)
        {
            HotDogData = hotDogData;
        }

        public abstract string GetName();
        public abstract int GetCost();
        public abstract int GetWeight();

        public override string ToString()
        {
            return $"{GetName()} ({GetWeight()}ã) - {GetCost()}";
        }
    }
}