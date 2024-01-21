using Business.Abstract;
using Business.Requests.Car;
using Business.Responses.Car;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }


        [HttpGet]

        public GetCarListResponse GetList([FromQuery]GetCarListRequest request)
        {
            GetCarListResponse response = _carService.GetList(request);
            return response;
        }
    }
}
