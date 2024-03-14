using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class UserOperationClaim : Entity<int>
    {
        public virtual User User { get; set; } = default!;
        public virtual OperationClaim OperationClaim { get; set; } = default!;
    }
}
