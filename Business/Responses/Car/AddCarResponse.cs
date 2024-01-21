using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Car
{
    public class AddCarResponse
    {
        public AddCarResponse(int id, int colorId, int modelId, string carState, string kilometer, short modelYear, string plate)
        {
            if(!IsValidModelYear(modelYear))
            {
                throw new ArgumentException("Model yılı en fazla 20 yıl önceye ait olabilir");
            }
            Id = id;
            ColorId = colorId;
            ModelId = modelId;
            CarState = carState;
            Kilometer = kilometer;
            ModelYear = modelYear;
            Plate = plate;
        }

        public int Id { get; set; }
        public int ColorId { get; set; }

        public int ModelId { get; set; }

        public string CarState { get; set; }

        public string Kilometer { get; set; }

        public short ModelYear { get; set; }

        public string Plate { get; set; }

        private bool IsValidModelYear(short modelYear)
        {
            int currentYear = DateTime.Now.Year;
            return (currentYear - modelYear) <= 20;
        }

    }
}
