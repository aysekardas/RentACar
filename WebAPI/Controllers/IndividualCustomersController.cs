using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndividualCustomersController : ControllerBase
    {
        private readonly IIndividualCustomerService _individualCustomerService;
        public IndividualCustomersController(IIndividualCustomerService individualCustomerService)
        {
            _individualCustomerService = individualCustomerService;
        }
    }
}
