using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Car;
using Business.Responses.Car;
using DataAccess.Abstract;
using Entities.Concrete;
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
            if (!IsValidModelYear(request.ModelYear))
            {
                throw new ArgumentException("Model year can be up to 20 years old");
            }

            _carBusinessRules.CheckIfCarModelYearExists(request.ModelYear);

            var carToAdd = _mapper.Map<Car>(request);
            // Burada carToAdd ile yapılan işlemleri tamamlayın.

            var response = _mapper.Map<AddCarResponse>(carToAdd);
            return response;
        }

        private bool IsValidModelYear(short modelYear)
        {
            int currentYear = DateTime.Now.Year;
            return (currentYear - modelYear) <= 20;
        }
        public GetCarListResponse GetList(GetCarListRequest request)
        {
            IList<Car> carList = _carDal.GetList();
            GetCarListResponse response = _mapper.Map<GetCarListResponse>(carList);
            return response;
        }

    }

   
    }

