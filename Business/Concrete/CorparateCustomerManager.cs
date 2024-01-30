using AutoMapper;
using Business.Abstract;
using Business.Requests.CorporateCustomer;
using Business.Responses.CorpateCustomer;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CorparateCustomerManager : ICorporateCustomerService
    {
        private readonly ICorporateCustomerDal _corporateCustomerDal;
        private readonly CorparateCustomerManager _corporateCustomerManager;
        private readonly IMapper _mapper;

        public CorparateCustomerManager(ICorporateCustomerDal corporateCustomerDal, CorparateCustomerManager corporateCustomerManager, IMapper mapper)
        {
            _corporateCustomerDal = corporateCustomerDal;
            _corporateCustomerManager = corporateCustomerManager;
            _mapper = mapper;
        }

        public AddCorpateCustomerResponse Add(AddCorporateCustomerRequest request)
        {
            throw new NotImplementedException();
        }

        public DeleteCorporateCustomerResponse Delete(DeleteCorporateCustomerRequest request)
        {
            throw new NotImplementedException();
        }

        public GetCorporateCustomerByIdResponse GetById(GetCorporateCustomerByIdRequest request)
        {
            throw new NotImplementedException();
        }

        public GetCorporateCustomerListResponse GetList(GetCorporateCustomerListRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateCorporateCustomerResponse Update(UpdateCorporateCustomerRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
