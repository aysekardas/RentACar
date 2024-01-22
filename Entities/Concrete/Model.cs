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

        public Model(int brandId, int fuelId, int transmissionId, string name, short year, decimal dailyPrice)
        {
            BrandId = brandId;
            FuelId = fuelId;
            TransmissionId = transmissionId;
            Name = name;
            Year = year;
            DailyPrice = dailyPrice;
        }

        public int BrandId { get; set; } //normalizasyon

        public int FuelId { get; set; }
        public int TransmissionId { get; set; } 

        public string Name { get; set; }
        public short Year { get; set; }

        public decimal DailyPrice { get; set; }

        //lazy loading

        public Brand? Brand { get; set; } = null; //one-to-one ilişki

        public Fuel? Fuel { get; set; } = null; //one-to-one ilişki

        public Transmission? Transmission { get; set; } = null; //one-to-one ilişki

        public ICollection<Car>? Cars { get; set; } = null;  //model ile car arasında one-to many ilişki var.



    }
}
