using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Fuel;
using Business.Requests.Transmission;
using Business.Responses.Transmission;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TransmissionManager : ITransmissionService
    {
        private readonly ITransmissionDal _transmissionDal;
        private readonly TransmissionBusinessRules _transmissionBusinessRules;
        private readonly IMapper _mapper;

        public TransmissionManager(ITransmissionDal transmissionDal, TransmissionBusinessRules transmissionBusinessRules, IMapper mapper)
        {
            _transmissionDal = transmissionDal;
            _transmissionBusinessRules = transmissionBusinessRules;
            _mapper = mapper;
        }

        public AddTransmissionResponse Add(AddTransmissionRequest request)
        {
            _transmissionBusinessRules.CheckIfTransmissionNameNotExists(request.Name);
            Transmission transmissionToAdd = _mapper.Map<Transmission>(request);
            _transmissionDal.Add(transmissionToAdd);

            AddTransmissionResponse response = _mapper.Map<AddTransmissionResponse>(transmissionToAdd);
            return response;
        }

        public DeleteTransmissionResponse Delete(DeleteTransmissionRequest request)
        {
            throw new NotImplementedException();
        }

        public GetTransmissionByIdResponse GetById(GetTransmissionByIdRequest request)
        {
            throw new NotImplementedException();
        }

        public GetTransmissionListResponse GetList(GetTransmissionListRequest request)
        {
            IList<Transmission> transmissionList = _transmissionDal.GetList();
            GetTransmissionListResponse response = _mapper.Map<GetTransmissionListResponse>(transmissionList);
            return response;
           // return transmissionList;
        }

        public UpdateTransmissionResponse Update(UpdateTransmissionRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
