﻿using Business.Requests.Transmission;
using Business.Responses.Transmission;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITransmissionService
    {
        public AddTransmissionResponse Add(AddTransmissionRequest request);


        public GetTransmissionListResponse GetList(GetTransmissionListRequest request);
        //public IList<Transmission> GetList();

        public GetTransmissionByIdResponse GetById(GetTransmissionByIdRequest request);

        public UpdateTransmissionResponse Update(UpdateTransmissionRequest request);
        public DeleteTransmissionResponse Delete(DeleteTransmissionRequest request);
    }
}
