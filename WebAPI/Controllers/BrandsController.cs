using Business;
using Business.Abstract;
using Business.Concrete;
using Business.Requests.Brand;
using Business.Responses.Brand;
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
        private readonly IBrandService _brandService; //Field

        public BrandsController(IBrandService brandService)

        {
            //Her HTTP Request için yeni bir Controller nesnesi oluşturuyor.
            //IBrandDal brandDal = new InMemoryBrandDal();
            //_brandService = new BrandManager(brandDal);
            //IoC Container yapısını kurunca dependency injection ile olacak.


           // _brandService = ServiceRegistration.BrandService;
            _brandService = brandService;
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
        public GetBrandListResponse GetList([FromQuery]GetBrandListRequest request) // Referans tipleri varsayılan olarak request body'den alır.
        {
            
            GetBrandListResponse response = _brandService.GetList(request);
            return response; //JSON
        }

        //[HttpPost("/add")]  // POST http://localhost:5112/api/brands/add //endpoint 

        [HttpPost]  // POST http://localhost:5112/api/brands
        public ActionResult<AddBrandResponse>Add(AddBrandRequest request)
        {
            try
            {
                AddBrandResponse response = _brandService.Add(request);
                //return response;
                return CreatedAtAction(nameof(GetList), response);
            }


            catch (Core.CrossCuttingConcerns.Exceptions.BusinessException exception)
            {
                return BadRequest(

                    new Core.CrossCuttingConcerns.Exceptions.BusinessProblemDetails()
                    {
                        Title = "Business Exception",
                        Status = StatusCodes.Status400BadRequest,
                        Detail = exception.Message,
                        Instance = HttpContext.Request.Path
                    }
                ); //400 Bad Request

            }
        }
        
        
    }
}
