using Core.DataAccess.InMemory;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory;

public class InMemoryBrandDal : InMemoryEntityRepositoryBase<Brand, int>, IBrandDal
{
    protected override int generateId()
    {

        int nextId = Entities.Count == 0 ? 1 : Entities.Max(e => e.Id) + 1;
        return nextId;
    }

    //public IList<Brand> GetBrandsByNameSearch(string nameSearch)
    //{
    //    throw new NotImplementedException();
    //}


    //private readonly HashSet<Brand> Entities = new();

    //public void Add(Brand entity)
    //{
    //    entity.CreatedAt = DateTime.UtcNow;
    //    Entities.Add(entity);
    //}

    //public void Delete(Brand entity)
    //{
    //    entity.DeletedAt = DateTime.UtcNow;
    //}

    //public Brand? GetById(int id)
    //{
    //    Brand? entity = Entities.FirstOrDefault(
    //        e => e.Id.Equals(id) && e.DeletedAt.HasValue == false
    //    );
    //    return entity;
    //}

    //public IList<Brand> GetList()
    //{
    //    IList<Brand> entities = Entities.Where(e => e.DeletedAt.HasValue == false).ToList();
    //    return entities;
    //}

    //public void Update(Brand entity)
    //{
    //    entity.UpdateAt = DateTime.UtcNow;
    //}
}