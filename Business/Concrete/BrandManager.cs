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
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        //Bir entity service'i kendi entitysi dışında hiçbir entity'nin DAL'ını enjekte etmemelidir.
        private readonly IBrandDal _brandDal; 
        private readonly BrandBusinessRules _brandBusinessRules;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

      

        public BrandManager(IBrandDal brandDal, BrandBusinessRules brandBusinessRules, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {    //new InMemoryBrandDal(); //Başka katmanların class'ları new'lenmez. //Bu yüzden dependency injection

            _brandDal = brandDal;
             _brandBusinessRules = brandBusinessRules;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;

        }

        // AOP => Aspect Oriented Programming - Autofac
        // Pipeline 
        public AddBrandResponse Add(AddBrandRequest request)
        {

            if (!_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                throw new Exception("Bu endpointi çalıştırmak için giriş yapmak zorundasınız!");
            }

            _brandBusinessRules.CheckIfBrandNameNotExists(request.Name);
       
            Brand brandToAdd = _mapper.Map<Brand>(request);      //Mapping 
            _brandDal.Add(brandToAdd);

           

            AddBrandResponse response = _mapper.Map<AddBrandResponse>(brandToAdd);
            return response;


            //Brand addedBrand = _brandDal.Add();
        }

        public DeleteBrandResponse Delete(DeleteBrandRequest request)
        {
            throw new NotImplementedException();
        }

        public GetBrandByIdResponse GetById(GetBrandByIdRequest request)
        {
            throw new NotImplementedException();
        }

        public Brand? GetById(int id)
        {
            return _brandDal.Get(i => i.Id == id);
        }

        public GetBrandListResponse GetList(GetBrandListRequest request)
        {
            //brandList.Items diye bir alan yok, bu yüzden mapping
            //Brand => BrandListItemDto
           // IList<BrandListItemDto> GetBrandListResponse

            IList<Brand> brandList = _brandDal.GetList();
            GetBrandListResponse response = _mapper.Map<GetBrandListResponse>(brandList);
            return response;
        }

        public UpdateBrandResponse Update(UpdateBrandRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

