using Business.Dtos.Customer;

namespace Business.Abstract
{
    public class GetCustomerListResponse
    {

        public ICollection<CustomerListItemDto> Items { get; set; }
    }
}