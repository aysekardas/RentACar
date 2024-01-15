using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using Business.Requests.Brand;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace WebAPI
{
    //Proje başlayınca bir kere referansı oluşturulacak ve propertylerde bir kere oluşturulacak
    //Dışarıdan atama olmasın diye readonly
    public static class ServiceRegistration
    {
        public static readonly IBrandDal BrandDal = new InMemoryBrandDal();
        public static readonly BrandBusinessRules BrandBusinessRules = new BrandBusinessRules(BrandDal);
        public static IMapper Mapper => new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<AddBrandRequest, Brand>();
            cfg.CreateMap<Brand, AddBrandRequest>();
        }).CreateMapper();
        
        public static readonly IBrandService BrandService = new BrandManager
            (BrandDal,

            BrandBusinessRules,
            Mapper);

    }

    //IoC Container yapımızı kurunca Dependency Injection ile daha verimli hale gelecek
}
