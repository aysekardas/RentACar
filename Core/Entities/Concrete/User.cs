using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class User : Entity<int>
    {
        //GENEL USER FIELDLARI
        public string Email { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public bool Approved { get; set; }

        public bool Status { get; set; }
        //abc123 => plain text
        //hashing, SHA512, MD5=>DOKLJBDKSKLB22VKL
        //Salting => abc123 + SALT => HASH =>

        public virtual ICollection<UserOperationClaim> UserOperationClaims { get; set; } = default!;


    }
}
