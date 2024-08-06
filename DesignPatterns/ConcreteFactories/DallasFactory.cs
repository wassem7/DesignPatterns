using DesignPatterns.BicycleTypes;
using DesignPatterns.FactoryMethodPattern;
using DesignPatterns.Interfaces;

namespace DesignPatterns.ConcreteFactories;

public class DallasFactory : BicycleFactory
{
    public override IBicycle CreateBicycle(string bikeType)
    {
        return bikeType switch
        {
            "mountainbike" => new MountainBike(),
            _ => throw new Exception($"Invalid bike type : {bikeType}")
        };
    }
}
