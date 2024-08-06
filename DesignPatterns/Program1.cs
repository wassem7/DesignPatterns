using DesignPatterns.AbstractFactory;

namespace DesignPatterns;

public class Program1
{
    public static void Main()
    {
        var mountainBikeFactory = new MountainBikeFactory();

        var handleBar = mountainBikeFactory.CreateHandleBar();
    }
}
