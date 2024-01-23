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
            //if(!IsValidModelYear(modelYear))
            //{
            //    throw new ArgumentException("Model year can be up to 20 years old");
            //}
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

        

    }
}
