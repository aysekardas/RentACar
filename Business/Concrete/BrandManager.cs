using Business.Abstract;
using Business.BusinessRules;
using DataAccess.Abstract;
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
        private readonly BrandBusinessRules brandBusinessRules;
        public BrandManager(IBrandDal brandDal, BrandBusinessRules brandBusinessRules)
        {     //new InMemoryBrandDal();
            //Başka katmanların class'ları new'lenmez. 
            //Bu yüzden dependency injection
            _brandDal = brandDal;
             brandBusinessRules = brandBusinessRules;
       
        }
        public Brand Add(Brand brand )
        {
            brandBusinessRules.CheckIfBrandNameNotExists(brand.Name);
            //addBrandRequest
            //İş kuralları
            //validation
            //yetki kontrolü
            //Cache
            //Transaction
            _brandDal.Add(brand);
            return brand;


            //Brand addedBrand = _brandDal.Add();
        }

        public IList<Brand> GetList()
        {
            IList<Brand> brandList = _brandDal.GetList();
            return brandList;
        }
    }
}
