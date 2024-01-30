using Business.Requests.IndividualCustomer;
using Business.Responses.IndividualCustomer;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IIndividualCustomerService
    {
        public AddIndividualCustomerResponse Add(AddIndividualCustomerRequest request);

        public GetIndividualCustomerListResponse GetList(GetIndividualCustomerListRequest request);

        public GetIndividualCustomerByIdResponse GetById(GetIndividualCustomerByIdRequest request);

        public UpdateIndividualCustomerResponse Update(UpdateIndividualCustomerRequest request);

        public DeleteIndividualCustomerResponse Delete(DeleteIndividualCustomerRequest request);


    }
}
