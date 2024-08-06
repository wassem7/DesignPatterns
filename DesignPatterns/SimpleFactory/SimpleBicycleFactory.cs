using DesignPatterns.BicycleTypes;

namespace DesignPatterns.SimpleFactory;

public class SimpleBicycleFactory
{
    public Bicycle CreateBicycle(string bicycle)
    {
        switch (bicycle)
        {
            case "mountainbike":
                return new MountainBike();

            case "roadbike":
                return new RoadBike();

            default:
                throw new Exception($"Invalid bike type : {bicycle}");
        }
    }
}
