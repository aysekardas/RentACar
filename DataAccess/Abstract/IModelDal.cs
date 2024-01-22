using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IModelDal : IEntityRepository<Model, int>
    {
        #region
        // {
        //public IList<Model> GetList();
        //public Model? GetById(Model id);
        //public void Add(Model entity);
        //public void Update(Model entity);
        //public void Delete(Model entity);
        //}
        //IModelDal modelDal = new InMemoryModelDal();
        //Model modelToAdd = new Model { Id = 1, Name = "Astra" };
        //modelDal.Add(modelToAdd);
        #endregion
    }


}
