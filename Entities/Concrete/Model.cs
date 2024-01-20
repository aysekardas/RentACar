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
        public int Id { get; set; }
        public int BrandId { get; set; }

        public int FuelId { get; set; }
        public int TranmissionId { get; set; }

        public decimal DailyPrice { get; set; }
        public string Name { get; set; }

        public short Year { get; set; }

        public Brand? Brand { get; set; } = null;

        public Fuel? Fuel { get; set; } = null;

        public Transmission? Transmission { get; set; } = null;



    }
}
