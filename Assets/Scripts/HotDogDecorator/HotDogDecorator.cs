namespace HotDog
{
    public abstract class HotDogDecorator : HotDog
    {
        protected HotDog hotDog;

        //Конструктор
        public HotDogDecorator(HotDogData hotDogData, HotDog hotDog) : base(hotDogData)
        {
            this.hotDog = hotDog;
        }
    }
}