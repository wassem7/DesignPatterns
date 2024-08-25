using DesignPatterns.Interfaces;

namespace DesignPatterns.BuilderPattern;

public interface IBicycleBuilder
{
    public void BuildFrame();
    public void BuildHandleBar();
    public IBicycleProduct GetBicycleProduct();

    public void Reset();
}
