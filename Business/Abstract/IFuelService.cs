using Business.Requests.Fuel;
using Business.Responses.Fuel;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFuelService

    {

        public AddFuelResponse Add(AddFuelRequest request);

        public GetFuelListResponse GetList(GetFuelListRequest request);
        //public IList<Fuel> GetList();
        public GetFuelByIdResponse GetById(GetFuelByIdRequest request);

        public UpdateFuelResponse Update(UpdateFuelRequest request);
        public DeleteFuelResponse Delete(DeleteFuelRequest request);
    }
}
