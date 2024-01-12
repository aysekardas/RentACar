using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        //field olarak Brand'i tanımlayalım
        private readonly IBrandService _brandService;

        public BrandsController()

        {
            //Her HTTP Request için yeni bir Controller nesnesi oluşturuyor.
            //IBrandDal brandDal = new InMemoryBrandDal();
            //_brandService = new BrandManager(brandDal);
            //IoC Container yapısını kurunca dependency injection ile olacak.


            _brandService = ServiceRegistration.BrandService;
        }

        //[HttpGet]
        //public ActionResult<string> GetList() /*IActionResult GetList()*/
        //{
        //    return Ok("BrandsController");
        //} 

        //[HttpGet]
        //public string GetList() //Veriyi direk bu şekilde dönebilirim
        //{
        //    return "BrandsController";
        //}


        [HttpGet]
        public ICollection<Brand> GetList()
        {
            IList<Brand> brandList = _brandService.GetList();
            return brandList;
        }

        //[HttpPost("/add")]  // POST http://localhost:5112/api/brands/add //endpoint 

        [HttpPost]  // POST http://localhost:5112/api/brands
        public Brand Add(Brand addBrandRRequest)
        {
            Brand addedBrand = _brandService.Add(addBrandRRequest);
            return addedBrand;

        }
        
        
    }
}
