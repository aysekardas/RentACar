using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class CarBusinessRules
    {
        private readonly ICarDal _carDal;

        public CarBusinessRules(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void CheckIfCarModelYearExists(short modelYear)
        {
            bool isExists = _carDal.Get(car => car.ModelYear == modelYear) is not null;
            if (!isExists)
            {
                throw new BusinessException("Model year already exists.");
            }
        }
    }
}
