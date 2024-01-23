using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Car;
using Business.Responses.Car;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;
        private readonly CarBusinessRules _carBusinessRules;
        private readonly IMapper _mapper;

        public CarManager(ICarDal carDal, CarBusinessRules carBusinessRules, IMapper mapper)
        {
            _carDal = carDal;
            _carBusinessRules = carBusinessRules;
            _mapper = mapper;
        }

        public AddCarResponse Add(AddCarRequest request)
        {
            throw new NotImplementedException();
        }

        public GetCarListResponse GetList(GetCarListRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
