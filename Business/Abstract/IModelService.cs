using Business.Requests.Car;
using Business.Requests.Model;
using Business.Responses.Car;
using Business.Responses.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IModelService

    {
        public AddModelResponse
            Add(AddModelRequest request);

        public GetModelListResponse GetList(GetModelListRequest request);
        
    }
}
