using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class CorparateCustomerBusinessRules
    {
        private readonly ICorporateCustomerDal _corporateCustomerDal;

        public CorparateCustomerBusinessRules(ICorporateCustomerDal corporateCustomerDal)
        {
            _corporateCustomerDal = corporateCustomerDal;
        }
    }
}
