using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfIndividualCustomer : IIndividualCustomer
    {
        private readonly RentACarContext _context;

        public EfIndividualCustomer(RentACarContext context)
        {
            _context = context;
        }

        public IIndividualCustomer Add(IIndividualCustomer entity)
        {
            throw new NotImplementedException();
        }

        public IIndividualCustomer Delete(IIndividualCustomer entity, bool isSoftDelete = true)
        {
            throw new NotImplementedException();
        }

        public IIndividualCustomer? Get(Func<IIndividualCustomer, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<IIndividualCustomer> GetList(Func<IIndividualCustomer, bool>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public IIndividualCustomer Update(IIndividualCustomer entity)
        {
            throw new NotImplementedException();
        }
    }
}
