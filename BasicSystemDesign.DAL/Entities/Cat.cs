using BasicSystemDesign.DAL.Interfaces;

namespace BasicSystemDesign.DAL.Entities;

public class Cat : IEntity, ICreature, IWalkable
{
    public Cat(int id, string name, double maxSprintDistance)
    {
        Id = id;
        Name = name;
        MaxSprintDistance = maxSprintDistance;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public double MaxSprintDistance { get; set; }
    private const string AnimalType = "Cat";
    
    public override string ToString()
    {
        return $"ID: {Id} | Name: {Name} | Max Sprint Distance: {MaxSprintDistance} | Animal Type: {AnimalType}";
    }
}