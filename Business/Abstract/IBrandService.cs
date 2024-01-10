
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        public Brand AddBrand(Brand brand);

        public IList<Brand> GetBrandList();
    }
}
