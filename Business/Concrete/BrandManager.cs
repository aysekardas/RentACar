using Business.Abstract;
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
       private IBrandDal _brandDal;
        
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal; 
            //new InMemoryBrandDal();
            //Başka katmanların class'ları new'lenmez. 
            //Bu yüzden dependency injection
        }
        public Brand Add(Brand brand )
        {
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
