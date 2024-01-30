using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class IndividualCustomerBusinessRules
    {

        private readonly IIndividualCustomerDal _individualCustomerDal;

        public IndividualCustomerBusinessRules(IIndividualCustomerDal individualCustomerDal)
        {
            _individualCustomerDal = individualCustomerDal;
        }
    }
}
