using DesignPatterns.Interfaces;

namespace DesignPatterns.FactoryMethodPattern;

public abstract class BicycleFactory
{
    public abstract IBicycle CreateBicycle(string bikeType);
}
