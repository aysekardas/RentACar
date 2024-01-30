using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCorporateCustomerDal : ICorporateCustomerDal
    {
        private readonly RentACarContext _context;

        public CorporateCustomer Add(CorporateCustomer entity)
        {
            throw new NotImplementedException();
        }

        public CorporateCustomer Delete(CorporateCustomer entity, bool isSoftDelete = true)
        {
            throw new NotImplementedException();
        }

        public CorporateCustomer? Get(Func<CorporateCustomer, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<CorporateCustomer> GetList(Func<CorporateCustomer, bool>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public CorporateCustomer Update(CorporateCustomer entity)
        {
            throw new NotImplementedException();
        }
    }
}
