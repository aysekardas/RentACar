using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using Business.Requests.Brand;
using Business.Requests.Fuel;
using Business.Requests.Transmission;
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


        public static readonly ITransmissionDal TransmissionDal = new InMemoryTransmissionDal();
        public static readonly TransmissionBusinessRules TranmissionRules = new TransmissionBusinessRules(TransmissionDal);


        public static readonly IFuelDal FuelDal = new InMemoryFuelDal();
        public static readonly FuelBusinessRules FuelBusinessRules = new Business.BusinessRules.FuelBusinessRules(FuelDal);


        public static IMapper Mapper => new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<AddBrandRequest, Brand>();
            cfg.CreateMap<Brand, AddBrandRequest>();
            cfg.CreateMap<AddTransmissionRequest, Transmission>();
            cfg.CreateMap<Transmission, AddTransmissionRequest>();
            cfg.CreateMap<AddFuelRequest, Fuel>();
            cfg.CreateMap<Fuel,AddFuelRequest>();

        }).CreateMapper();
        
        public static readonly IBrandService BrandService = new BrandManager
            (BrandDal,

            BrandBusinessRules,
            Mapper);

        public static readonly ITransmissionService TransmissionService = new TransmissionManager
            (TransmissionDal, TranmissionRules, Mapper);

        public static readonly IFuelService FuelService = new FuelManager(FuelDal, FuelBusinessRules, Mapper);



    }

    //IoC Container yapımızı kurunca Dependency Injection ile daha verimli hale gelecek
}
