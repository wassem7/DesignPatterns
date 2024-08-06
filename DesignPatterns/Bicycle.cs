using DesignPatterns.Enumerations;
using DesignPatterns.Interfaces;

namespace DesignPatterns;

public abstract class Bicycle : IBicycle
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");

    public string ModelName { get; set; }

    public int Year { get; set; }

    public string SerialNumber { get; }

    public BicyclePaintColors Color { get; set; }

    public BicycleGeometry Geometry { get; set; }

    public SuspensionTypes Suspension { get; set; }

    public ManufacturingStatus BuildStatus { get; set; }

    protected Bicycle()
    {
        ModelName = string.Empty;
        SerialNumber = Guid.NewGuid().ToString("N");
        Year = DateTime.Now.Year;
        BuildStatus = ManufacturingStatus.Specified;
    }

    public void Build()
    {
        Console.WriteLine($"Manufacturing a {Geometry.ToString()} frame...");
        BuildStatus = ManufacturingStatus.FrameManufactured;

        Console.WriteLine($"Painting the frame {Color.ToString()}");
        BuildStatus = ManufacturingStatus.Painted;

        if (Suspension != SuspensionTypes.HardTail)
        {
            Console.WriteLine($"Mounting the {Suspension.ToString()} suspension.");
            BuildStatus = ManufacturingStatus.SuspensionMounted;
        }
        Console.WriteLine(
            "{0} {1} Bicycle serial number {2} manufacturing complete!",
            Year,
            ModelName,
            SerialNumber
        );
        BuildStatus = ManufacturingStatus.Complete;
    }
}
