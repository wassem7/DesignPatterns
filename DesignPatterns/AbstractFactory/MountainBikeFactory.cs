using DesignPatterns.Components.MountainBike;
using DesignPatterns.Interfaces;

namespace DesignPatterns.AbstractFactory;

public class MountainBikeFactory : IBicycleFactory
{
    public IFrame CreateFrame()
    {
        return new MountainBikeFrame();
    }

    public IHandleBar CreateHandleBar()
    {
        return new MountainBikeHandleBar();
    }
}
