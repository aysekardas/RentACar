namespace Core.DataAccess;

public interface IEntityRepository<TEntity, TEntityId>
{
    public IList<TEntity> GetList(Func<TEntity, bool>? predicate = null);

    #region Func
    //Func fonksiyonları tutabileceğimiz bir type'dır.
    //Jeneric yapısında en son type argümanı fonksiyonun dönüş tipidir.
    //Ondan önce gelen type argümanları fonksiyonun sırasıyla parametre tipleridir.

    //Func<TEntity, bool> predicate = (TEntity entity) => {  return entity.Name==";}

    //    bool predicate(TEntity entity)
    //    {
    //        bool result = entity.Name == "";
    //        return result;
    //    }
    //    Func<TEntity, bool> predicateFunc = predicate;
    #endregion

    public TEntity? Get(Func<TEntity, bool> predicate);
    public TEntity Add(TEntity entity);
    public TEntity Update(TEntity entity);
    //public TEntity Delete(TEntity entity);

    public TEntity Delete(TEntity entity, bool isSoftDelete = true);
}