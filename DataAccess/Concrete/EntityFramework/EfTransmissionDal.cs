using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    internal class EfTransmissionDal : ITransmissionDal
    {
        public Transmission Add(Transmission entity)
        {
            throw new NotImplementedException();
        }

        public Transmission Delete(Transmission entity)
        {
            throw new NotImplementedException();
        }

        public Transmission? Get(Func<Transmission, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<Transmission> GetList(Func<Transmission, bool>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public Transmission Update(Transmission entity)
        {
            throw new NotImplementedException();
        }
    }
}
