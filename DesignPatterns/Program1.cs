using DesignPatterns.AbstractFactory;
using DesignPatterns.BuilderPattern;

namespace DesignPatterns;

public class Program1
{
    public static void Main()
    {
        var roadBikeBuilder = new RoadBikeBuilder();

        var director = new Director(roadBikeBuilder);

        var roadBike = director.Make();
    }
}
