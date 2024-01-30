using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class CorporateCustomerBusinessRules
    {
        private readonly ICorporateCustomerDal _corporateCustomerDal;

        public CorporateCustomerBusinessRules(ICorporateCustomerDal corporateCustomerDal)
        {
            _corporateCustomerDal = corporateCustomerDal;
        }
    }
}
