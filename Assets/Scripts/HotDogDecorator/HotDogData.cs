using UnityEngine;
using System;

namespace HotDog
{
    [CreateAssetMenu(fileName = "HotDogData", menuName = "SO/NewHotDogData")]
    public class HotDogData : ScriptableObject
    {
        //сериализованное поля
        public string name;
        public int cost;
        public int weight;
        public Ingredient extraIngredient;
    }

    [Serializable]
    public class Ingredient
    {
        public string name;
        public int cost;
        public int weight;
    }
}