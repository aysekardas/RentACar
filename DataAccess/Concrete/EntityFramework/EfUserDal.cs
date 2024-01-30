using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class EfUserDal : IUserDal
    {
        private readonly RentACarContext _context;

        public EfUserDal(RentACarContext context)
        {
            _context = context;
        }

        public User Add(User entity)
        {
            throw new NotImplementedException();
        }

        public User Delete(User entity, bool isSoftDelete = true)
        {
            throw new NotImplementedException();
        }

        public User? Get(Func<User, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<User> GetList(Func<User, bool>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public User Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
