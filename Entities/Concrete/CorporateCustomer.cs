using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CorporateCustomer : Entity<int>
    {

        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public short TaxNo { get; set; }

        public User? User { get; set; } = null;
        public Customer? Customer { get; set; } = null;
    }
}
