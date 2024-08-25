using DesignPatterns.Interfaces;

namespace DesignPatterns;

public class BicycleProduct : IBicycleProduct
{
    public IFrame Frame { get; set; }
    public IHandleBar HandleBar { get; set; }
}
