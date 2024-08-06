using DesignPatterns.Components.RoadBike;
using DesignPatterns.Interfaces;

namespace DesignPatterns.AbstractFactory;

public class RoadBikeFactory : IBicycleFactory
{
    public IFrame CreateFrame()
    {
        return new RoadBikeFrame();
    }

    public IHandleBar CreateHandleBar()
    {
        return new RoadBikeHandleBar();
    }
}
