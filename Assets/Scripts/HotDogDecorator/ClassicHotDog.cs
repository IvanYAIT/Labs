namespace HotDog
{
    public class ClassicHotDog : HotDog
    {
        public ClassicHotDog(HotDogData hotDogData) : base(hotDogData)
        {
        }

        public override int GetCost() => HotDogData.cost;

        public override string GetName() => HotDogData.name;

        public override int GetWeight() => HotDogData.weight;
    }
}