using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CorporateCustomersController : ControllerBase
    {
        private readonly ICorporateCustomerService _corporateCustomerService;
        public CorporateCustomersController(ICorporateCustomerService corporateCustomerService)
        {
            _corporateCustomerService = corporateCustomerService;
        }
    }
}
