using Entities.Interfaces;

namespace Entities.Entities;

public class Bird : IEntity, ICreature, IFlyable
{
    public Bird(int id, string name, double maxFlyingHeight)
    {
        Id = id;
        Name = name;
        MaxFlyingHeight = maxFlyingHeight;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public double MaxFlyingHeight { get; set; }
    
    public override string ToString()
    {
        return $"ID: {Id} | Name: {Name} | Max Flying Height: {MaxFlyingHeight}";
    }
}