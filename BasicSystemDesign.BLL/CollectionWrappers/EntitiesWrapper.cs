using BasicSystemDesign.DAL.Entities;

namespace BasicSystemDesign.Bll.CollectionWrappers;

public class EntitiesWrapper
{
    private readonly List<IEntity> _entities;

    public EntitiesWrapper()
    {
        _entities = new List<IEntity>();
    }

    public void AddEntity(IEntity entity)
    {
        if (entity is null)
        {
            throw new ArgumentNullException(nameof(entity));
        }

        _entities.Add(entity);
    }

    public void RemoveEntity(IEntity entity)
    {
        if (entity is null)
        {
            throw new ArgumentNullException(nameof(entity));
        }

        _entities.Remove(entity);
    }

    public void ShowAll()
    {
        foreach (var entity in _entities)
        {
            Console.WriteLine(entity.ToString());
        }
    }
}