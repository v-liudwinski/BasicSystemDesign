using Entities.Interfaces;

namespace Entities.Entities;

public class Plain : IEntity, IMachine, IFlyable
{
    public Plain(int id, string model, double maxFlyingHeight)
    {
        Id = id;
        Model = model;
        MaxFlyingHeight = maxFlyingHeight;
    }

    public int Id { get; set; }
    public string Model { get; set; }
    public double MaxFlyingHeight { get; set; }

    public override string ToString()
    {
        return $"ID: {Id} | Model: {Model} | Max Flying Height: {MaxFlyingHeight}";
    }
}