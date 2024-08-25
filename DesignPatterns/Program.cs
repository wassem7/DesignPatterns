using DesignPatterns.BicycleTypes;
using DesignPatterns.ConcreteFactories;
using DesignPatterns.Interfaces;
using DesignPatterns.SimpleFactory;

namespace DesignPatterns;

class Program
{
    static void main(string[] args)
    {
        // Bicycle bikeToBuild;
        //
        // Console.WriteLine("Enter bike type ...");
        //
        // var input = Console.ReadLine();
        //
        // var bicycleFactory = new SimpleBicycleFactory();
        //
        // bikeToBuild = bicycleFactory.CreateBicycle(input!);
        //
        // bikeToBuild.Build();
        Console.WriteLine("Enter a bike type");

        var input = Console.ReadLine();

        IBicycle bikeToBuild;

        var dallasBikeFactory = new DallasFactory();

        bikeToBuild = dallasBikeFactory.CreateBicycle(input!);

        bikeToBuild.Build();
    }
}
