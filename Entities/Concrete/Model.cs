using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Model : Entity<int>
    {
    
        public Model()
        {
            
        }

        public Model(int id, string name, Brand? brand, Fuel? fuel, Transmission? transmission, Car? car)
        {
            Id = id;
            Name = name;
            Brand = brand;
            Fuel = fuel;
            Transmission = transmission;
            Car = car;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public Brand? Brand { get; set; } = null;

        public Fuel? Fuel { get; set; } = null;

        public Transmission? Transmission { get; set; } = null;

        public Car? Car { get; set; } = null;

    }
}
