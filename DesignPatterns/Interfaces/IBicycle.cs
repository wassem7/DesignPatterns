using DesignPatterns.Enumerations;

namespace DesignPatterns.Interfaces;

public interface IBicycle
{
    public string Id { get; set; }

    public string ModelName { get; set; }

    public int Year { get; }

    public string SerialNumber { get; }

    public BicyclePaintColors Color { get; set; }

    public BicycleGeometry Geometry { get; set; }

    public SuspensionTypes Suspension { get; set; }

    public ManufacturingStatus BuildStatus { get; set; }

    public void Build();
}
