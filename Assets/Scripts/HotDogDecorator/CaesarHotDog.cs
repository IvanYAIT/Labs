namespace HotDog
{
    public class CaesarHotDog : HotDog
    {
        public CaesarHotDog(HotDogData hotDogData) : base(hotDogData)
        {
        }

        public override int GetCost() => HotDogData.cost;

        public override string GetName() => HotDogData.name;

        public override int GetWeight() => HotDogData.weight;
    }

}