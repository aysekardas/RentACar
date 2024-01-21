using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car : Entity<int>
    {
        public Car()
        {
        }

        public Car(int id)
        {
            Id = id;
        }

        public int Id { get; set; }




    }
}
