using DesignPatterns.Enumerations;

namespace DesignPatterns.BicycleTypes;

public class RoadBike : Bicycle
{
    public RoadBike()
    {
        ModelName = "Hillcrest";
        Suspension = SuspensionTypes.HardTail;
        Color = BicyclePaintColors.Blue;
        Geometry = BicycleGeometry.UpRight;
    }
}
