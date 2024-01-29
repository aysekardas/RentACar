using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities.Concrete
{
    public class Brand : Entity<int>
    {

        public string Name { get; set; }

        public Brand()
        {

        }
        public Brand(string name) 
        {
            Name = name;
        }


        public ICollection<Model> Models { get; set; } = null;
    }
}
