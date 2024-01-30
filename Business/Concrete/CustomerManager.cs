using AutoMapper;
using Business.Abstract;
using Business.Requests.Customer;
using Business.Responses.Customer;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        private readonly CustomerManager _customerManager;
        private readonly IMapper _mapper;

        public CustomerManager(ICustomerDal customerDal, CustomerManager customerManager, IMapper mapper)
        {
            _customerDal = customerDal;
            _customerManager = customerManager;
            _mapper = mapper;
        }

        public AddCustomerResponse Add(AddCustomerRequest request)
        {
            throw new NotImplementedException();
        }

        public DeleteCustomerResponse Delete(DeleteCustomerRequest request)
        {
            throw new NotImplementedException();
        }

        public GetCustomerByIdResponse GetById(GetCustomerByIdRequest request)
        {
            throw new NotImplementedException();
        }

        public GetCustomerListResponse GetList(GetCustomerListRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateCustomerResponse Update(UpdateCustomerRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
