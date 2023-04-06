namespace HotDog
{
    public class DecoratedClassicHotDog : HotDogDecorator
    {
        protected Ingredient ingredient;

        //Конструктор
        public DecoratedClassicHotDog(HotDogData hotDogData, HotDog hotDog) : base(hotDogData, hotDog)
        {
            ingredient = hotDogData.extraIngredient;
        }

        public override int GetCost() => hotDog.GetCost() + ingredient.cost;

        public override int GetWeight() => hotDog.GetWeight() + ingredient.weight;

        public override string GetName() => hotDog.GetName() + " c " + ingredient.name;
    }

}