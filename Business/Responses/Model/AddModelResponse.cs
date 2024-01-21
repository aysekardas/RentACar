using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Model
{
    public class AddModelResponse
    {
        public AddModelResponse(int id, int brandId, int fuelId, int tranmissionId, decimal dailyPrice, string name, short year)
        {
            Id = id;
            BrandId = brandId;
            FuelId = fuelId;
            TranmissionId = tranmissionId;
            DailyPrice = dailyPrice;
            Name = name;
            Year = year;
        }

        public int Id { get; set; }
        public int BrandId { get; set; }

        public int FuelId { get; set; }
        public int TranmissionId { get; set; }

        public decimal DailyPrice { get; set; }
        public string Name { get; set; }

        public short Year { get; set; }


     
    }
}
