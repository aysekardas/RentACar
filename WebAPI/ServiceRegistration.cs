using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;

namespace WebAPI
{
    //Proje başlayınca bir kere referansı oluşturulacak ve properylerde bir kere oluşturulacak
    //Dışarıdan atama olmasın diye readonly
    public static class ServiceRegistration
    {
        public static readonly IBrandDal BrandDal = new InMemoryBrandDal();
        public static readonly IBrandService BrandService = new BrandManager(BrandDal);

    }
}
