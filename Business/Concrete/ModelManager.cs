using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Model;
using Business.Responses.Model;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Business.Concrete
{
    public class ModelManager : IModelService
    {
        private readonly IModelDal _modelDal;
        private readonly IMapper _mapper;
        private readonly ModelBusinessRules _modelBusinessRules;

        public ModelManager(IModelDal modelDal, IMapper mapper, ModelBusinessRules modelBusinessRules)
        {
            _modelDal = modelDal;
            _mapper = mapper;
            _modelBusinessRules = modelBusinessRules;
        }

        public AddModelResponse Add(AddModelRequest request)
        {
            //Validation
            //fluent validation ile buradan ayrıştıracağız daha sonra
            if (request.Name.Length < 2)
                throw new Exception("Name must be at least 2 characters long.");
            if (request.Name.Length < 50)
                throw new Exception("Name cannot be longer then 50 characters");

            if (request.DailyPrice > 0)
                throw new Exception("Daily price must be greater than 0.");

            //business rules
            _modelBusinessRules.CheckIfModelNameExists(request.Name);

            //mapping
            var modelToAdd = _mapper.Map<Model>(request);

            //data operations

            Model updateModel = _modelDal.Add(modelToAdd);

            //response

            var response = _mapper.Map<AddModelResponse>(updateModel);

            return response;



        }

        public DeleteModelResponse Delete(DeleteModelRequest request)
        {
            throw new NotImplementedException();
        }

        public GetModelByIdResponse GetById(GetModelByIdRequest request)
        {
            throw new NotImplementedException();
        }

        public GetModelListResponse GetList(GetModelListRequest request)
        {
            //business rules

            //data access

            #region Farklı kullanım
            //bool predicate(Model model)
            //{

            //        return (request.FilterByBrandId == null || model.BrandId == request.FilterByBrandId)
            //            && (request.FilterByFuelId == null || model.FuelId == request.FilterByFuelId
            //            && (request.FilterByTransmissionId == null || model.TransmissionId == request.FilterByTransmissionId));



            //}
            //IList<Model> modelList = _modelDal.GetList(predicate);

            #endregion

            IList<Model> modelList = _modelDal.GetList(
                predicate : model =>
              (request.FilterByBrandId == null || model.BrandId == request.FilterByBrandId)
                        && (request.FilterByFuelId == null || model.FuelId == request.FilterByFuelId)
                        && (request.FilterByTransmissionId == null || model.TransmissionId == request.FilterByTransmissionId));

            var response = _mapper.Map<GetModelListResponse>(modelList);

            #region //mapping & response

            //var responseWithoutAutoMapper = new GetModelListResponse();
            //responseWithoutAutoMapper.Items = modelList
            //    .Select(
            //        model =>
            //            new ModelListItemDto
            //            {
            //                BrandId = model.BrandId,
            //                BrandName = model.Brand.Name,
            //                FuelId = model.FuelId,
            //                FuelName = model.Fuel.Name,
            //                Id = model.Id,
            //                Name = model.Name,
            //                TransmissionId = model.TransmissionId,
            //                TransmissionName = model.Transmission.Name
            //            }
            //    )
            //    .ToList();

            #endregion


            return response;
        }

        public UpdateModelResponse Update(UpdateModelRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
