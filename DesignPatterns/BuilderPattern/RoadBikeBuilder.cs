using DesignPatterns.Components.RoadBike;
using DesignPatterns.Interfaces;

namespace DesignPatterns.BuilderPattern;

public class RoadBikeBuilder : IBicycleBuilder
{
    private IBicycleProduct _bicycleProduct;

    public RoadBikeBuilder()
    {
        Reset();
    }

    public void BuildFrame()
    {
        _bicycleProduct.Frame = new RoadBikeFrame();
    }

    public void BuildHandleBar()
    {
        _bicycleProduct.HandleBar = new RoadBikeHandleBar();
    }

    public IBicycleProduct GetBicycleProduct()
    {
        return _bicycleProduct;
    }

    public void Reset()
    {
        _bicycleProduct = new BicycleProduct();
    }
}
