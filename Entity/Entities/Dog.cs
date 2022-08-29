using Entities.Interfaces;

namespace Entities.Entities;

public class Dog : IEntity, ICreature, IWalkable
{
    public Dog(int id, string name, double maxSprintDistance)
    {
        Id = id;
        Name = name;
        MaxSprintDistance = maxSprintDistance;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public double MaxSprintDistance { get; set; }
    private const string AnimalType = "Dog";
    
    public override string ToString()
    {
        return $"ID: {Id} | Name: {Name} | Max Sprint Distance: {MaxSprintDistance} | Animal Type: {AnimalType}";
    }
}