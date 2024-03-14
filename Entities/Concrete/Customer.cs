using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer : Entity<int>
    {
        public Customer()
        {
        }

        public Customer(int userId)
        {
            UserId = userId;
            
        }

        public int UserId { get; set; }

        public virtual User? User { get; set; } = null;
    }
}
