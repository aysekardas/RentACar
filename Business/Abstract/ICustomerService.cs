using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Responses.Customer;
using Business.Requests.Customer;

namespace Business.Abstract
{
    public interface ICustomerService
    {

        public AddCustomerResponse Add(AddCustomerRequest request);

        public GetCustomerListResponse GetList(GetCustomerListRequest request);

        public GetCustomerByIdResponse GetById(GetCustomerByIdRequest request);

        public UpdateCustomerResponse Update(UpdateCustomerRequest request);

        public DeleteCustomerResponse Delete(DeleteCustomerRequest request);

    }
}
