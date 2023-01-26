namespace HotDog
{
    public abstract class HotDogDecorator : HotDog
    {
        protected HotDog hotDog;

        public HotDogDecorator(HotDogData hotDogData, HotDog hotDog) : base(hotDogData)
        {
            this.hotDog = hotDog;
        }
    }
}