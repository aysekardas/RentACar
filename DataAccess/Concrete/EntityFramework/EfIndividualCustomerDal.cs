using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfIndividualCustomerDal : IIndividualCustomerDal
    {
        private readonly RentACarContext _context;

        public IIndividualCustomerDal Add(IIndividualCustomerDal entity)
        {
            throw new NotImplementedException();
        }

        public IIndividualCustomerDal Delete(IIndividualCustomerDal entity, bool isSoftDelete = true)
        {
            throw new NotImplementedException();
        }

        public IIndividualCustomerDal? Get(Func<IIndividualCustomerDal, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<IIndividualCustomerDal> GetList(Func<IIndividualCustomerDal, bool>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public IIndividualCustomerDal Update(IIndividualCustomerDal entity)
        {
            throw new NotImplementedException();
        }
    }
}
