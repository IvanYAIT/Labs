using UnityEngine;
using HotDog;

public class Debbuger : MonoBehaviour
{
    [SerializeField] private HotDogData classicHotDogData;
    [SerializeField] private HotDogData classicHotDogWithCucumberData;
    [SerializeField] private HotDogData classicHotDogWithOnionData;

    void Start()
    {
        ClassicHotDog classicHotDog = new ClassicHotDog(classicHotDogData);
        DecoratedClassicHotDog classicHotDogWithCucumber = new DecoratedClassicHotDog(classicHotDogWithCucumberData, classicHotDog);
        DecoratedClassicHotDog classicHotDogWithOnion = new DecoratedClassicHotDog(classicHotDogWithOnionData, classicHotDog);

        Debug.Log($"{classicHotDog.ToString()} \n" +
            $"Дополнительная информация: \n" +
            $"{classicHotDogWithCucumber.ToString()} \n" +
            $"{classicHotDogWithOnion.ToString()}\n");
    }
}
