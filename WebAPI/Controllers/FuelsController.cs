using Business.Abstract;
using Business.Requests.Fuel;
using Business.Responses.Fuel;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuelsController : ControllerBase
    {
        private readonly IFuelService _fuelService;

        public FuelsController(IFuelService fuelService)
        {
            _fuelService = fuelService;
            //_fuelService = ServiceRegistration.FuelService;
        }

        //[HttpGet]
        //public ICollection<Fuel>GetList()
        //{
        //    //IList<Fuel> fuelList = _fuelService.GetList();
        //    //return fuelList;
        //}

        [HttpGet]

        public GetFuelListResponse GetList([FromQuery] GetFuelListRequest request)
        {
            GetFuelListResponse response = _fuelService.GetList(request);
            return response;
        }

        [HttpPost]
        public ActionResult<AddFuelResponse>Add(AddFuelRequest request)
        {

            AddFuelResponse response = _fuelService.Add(request);
            return CreatedAtAction(nameof(GetList), response);  
        }
    }
}
