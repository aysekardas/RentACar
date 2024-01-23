using DataAccess.Abstract;
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
    }
}
