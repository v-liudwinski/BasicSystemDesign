using Entities.Entities;

namespace EntitiesCollection;

public class EntitiesCollection
{
    private readonly List<IEntity> _entities;

    public EntitiesCollection()
    {
        _entities = new List<IEntity>();
    }

    public void AddEntity(IEntity entity) => _entities.Add(entity);
    
    public void RemoveEntity(IEntity entity) => _entities.Remove(entity);

    public void ShowAll()
    {
        foreach (var entity in _entities)
        {
            Console.WriteLine(entity.ToString());
        }
    }
}