using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class IndividualCustomer : Entity<int>
    {
        public IndividualCustomer()
        {
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
        public virtual User? User { get; set; } = null;
        public virtual Customer? Customer { get; set; } = null;
    }
}
