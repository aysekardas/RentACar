using Business.Requests.Car;
using Business.Responses.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService

    {
       public AddCarResponse Add(AddCarRequest request);

        public GetCarListResponse GetList(GetCarListRequest request);
        public GetCarByIdResponse GetById(GetCarByIdRequest request);

        public UpdateCarResponse Update(UpdateCarRequest request);
        public DeleteCarResponse Delete(DeleteCarRequest request);
    }
}
