using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class ModelBusinessRules

    {
        private readonly IModelDal _modelDal;

        public ModelBusinessRules(IModelDal modelDal)
        {
            _modelDal = modelDal;
        }

        public void CheckIfModelNameExists(string name)
        {
            bool isNameExists = _modelDal.Get(m=>m.Name == name) != null;
            if (!isNameExists)
            {
                throw new BusinessException("Model name already exists.");
            }
        }

        public void CheckIfModelExists(Model? modelToDelete)
        {
            if (modelToDelete is null)

                throw new NotFoundException("Model not found");
        }
    }
}
