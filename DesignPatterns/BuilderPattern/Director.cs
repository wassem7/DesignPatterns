using DesignPatterns.Interfaces;

namespace DesignPatterns.BuilderPattern;

public class Director
{
    private IBicycleBuilder _bicycleBuilder;

    public Director(IBicycleBuilder bicycleBuilder)
    {
        _bicycleBuilder = bicycleBuilder;
    }

    public void ChangeBicycleBuilder(IBicycleBuilder bicycleBuilder)
    {
        _bicycleBuilder = bicycleBuilder;
    }

    public IBicycleProduct Make()
    {
        _bicycleBuilder.BuildHandleBar();
        _bicycleBuilder.BuildFrame();

        return _bicycleBuilder.GetBicycleProduct();
    }
}
