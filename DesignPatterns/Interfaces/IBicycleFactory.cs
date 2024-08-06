namespace DesignPatterns.Interfaces;

public interface IBicycleFactory
{
    public IFrame CreateFrame();

    public IHandleBar CreateHandleBar();
}
