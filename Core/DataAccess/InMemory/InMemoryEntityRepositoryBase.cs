using Core.Entities;

namespace Core.DataAccess.InMemory;

public abstract class InMemoryEntityRepositoryBase<TEntity, TEntityId>
    : IEntityRepository<TEntity, TEntityId>
    where TEntity : class, IEntity<TEntityId>, new()
{
    protected readonly HashSet<TEntity> Entities = new();

    protected abstract TEntityId generateId(); //Kalıtım alan classta tanımlayabilsin o yüzden protected
    
    public TEntity Add(TEntity entity)
    {
        entity.Id = generateId();
        entity.CreatedAt = DateTime.UtcNow;
        Entities.Add(entity);
        return entity;
    }

    public TEntity Delete(TEntity entity, bool isSoftDelete = true)
    {
        entity.DeletedAt = DateTime.UtcNow; //soft delete

        if(!isSoftDelete)
        Entities.Remove(entity); //hard delete
        return entity;
    }

    public TEntity? Get(Func<TEntity, bool> predicate)
    {
        TEntity? entity = Entities.FirstOrDefault(predicate);

        #region İlk Kullanım
        //TEntity? entity = Entities.FirstOrDefault(
        //    e => e.Id.Equals(id) && e.DeletedAt.HasValue == false
        //);
        #endregion

        return entity;
    }

    public IList<TEntity> GetList(Func<TEntity, bool>? predicate = null)
    {
        IEnumerable<TEntity> query = Entities;


        if (predicate != null)
            query = query.Where(predicate);

        return query.ToArray();


        #region IQueryable
        //IQueryable<TEntity> query = Entities.AsQueryable();

        //if (predicate != null) //predicate is not null
        //{
        //    query = query.Where(predicate).AsQueryable();
        //}

        //return query.ToList();

        #endregion

        #region İlk Kullanım
        //IList<TEntity> entities = Entities.Where(e => e.DeletedAt.HasValue == false).ToList();
        //return entities;
        #endregion
    }

    public TEntity Update(TEntity entity)
    {
        entity.UpdateAt = DateTime.UtcNow;
        return entity;
    }
}