using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Brand;
using Business.Requests.Transmission;
using Business.Responses.Brand;
using Business.Responses.Fuel;
using Business.Responses.Transmission;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
       private readonly IBrandDal _brandDal;
        private readonly BrandBusinessRules _brandBusinessRules;
        private readonly IMapper _mapper;
        public BrandManager(IBrandDal brandDal, BrandBusinessRules brandBusinessRules, IMapper mapper)
        {    //new InMemoryBrandDal(); //Başka katmanların class'ları new'lenmez. //Bu yüzden dependency injection

            _brandDal = brandDal;
             _brandBusinessRules = brandBusinessRules;
            _mapper = mapper;
       
        }
        public AddBrandResponse Add(AddBrandRequest request)
        {

            //addBrandRequest
            //İş kuralları
            _brandBusinessRules.CheckIfBrandNameNotExists(request.Name);
            //validation
            //yetki kontrolü
            //Cache
            //Transaction

            //Brand brandToAdd = new(request.Name); --Bunu yapmak yerine mapping yapacağız
       
            Brand brandToAdd = _mapper.Map<Brand>(request);      //Mapping 
            _brandDal.Add(brandToAdd);

           

            AddBrandResponse response = _mapper.Map<AddBrandResponse>(brandToAdd);
            return response;


            //Brand addedBrand = _brandDal.Add();
        }

        public IList<Brand> GetList()
        {
            IList<Brand> brandList = _brandDal.GetList();
            return brandList;
        }
    }
}

