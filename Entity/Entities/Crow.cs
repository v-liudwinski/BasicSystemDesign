using Entities.Interfaces;

namespace Entities.Entities;

public class Crow : IEntity, ICreature, IFlyable
{
    public Crow(int id, string name, double maxFlyingHeight)
    {
        Id = id;
        Name = name;
        MaxFlyingHeight = maxFlyingHeight;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public double MaxFlyingHeight { get; set; }
    private const string BirdType = "Crow";
    
    public override string ToString()
    {
        return $"ID: {Id} | Name: {Name} | Max Flying Height: {MaxFlyingHeight} | Bird Type: {BirdType}";
    }
}