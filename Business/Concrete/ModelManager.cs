using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Profiles.Validation.FluentValidation.Model;
using Business.Requests.Model;
using Business.Responses.Model;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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


            AddModelRequestValidator validator = new();
            validator.ValidateAndThrow(request);

            //business rules
            _modelBusinessRules.CheckIfModelNameExists(request.Name);
            _modelBusinessRules.CheckIfModelYearShouldBeInLast20Years(request.Year);

            //mapping
            _modelBusinessRules.CheckIfBrandExists(request.BrandId);
            var modelToAdd = _mapper.Map<Model>(request);
        

            //data operations

            Model addedModel = _modelDal.Add(modelToAdd);

            //response

            var response = _mapper.Map<AddModelResponse>(addedModel);

            return response;



        }

        public DeleteModelResponse Delete(DeleteModelRequest request)
        {
           Model? modelToDelete = _modelDal.Get(predicate: model=>model.Id == request.Id); /*0x123123*/
            _modelBusinessRules.CheckIfModelExists(modelToDelete);
            Model? deleteModel =  _modelDal.Delete(modelToDelete!);
           var response = _mapper.Map<DeleteModelResponse>(deleteModel);
            return response;
        }

        public GetModelByIdResponse GetById(GetModelByIdRequest request)
        {
            Model? model = _modelDal.Get(predicate:model=> model.Id == request.Id);
            _modelBusinessRules.CheckIfModelExists(model);
             
            var response = _mapper.Map<GetModelByIdResponse>(model);
            return response;
        }

        public GetModelListResponse GetList(GetModelListRequest request)
        {
            //business rules

            //data access

            #region Farklı kullanım
            //bool predicate(Model model)
            //{

            //        return (request.FilterByBrandId == null || model.Tr == request.FilterByBrandId)
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
            //                Tr = model.Tr,
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
            Model? modelToUpdate = _modelDal.Get(predicate: model => model.Id == request.Id); //0x123123
            _modelBusinessRules.CheckIfModelExists(modelToUpdate);
            _modelBusinessRules.CheckIfBrandExists(request.BrandId); 
            modelToUpdate = _mapper.Map(request, modelToUpdate); /*0x123123*/
            Model updatedModel = _modelDal.Update(modelToUpdate!); /*0x123123*/
                

            var response = _mapper.Map<UpdateModelResponse>(updatedModel);
            return response;
        }
    }
}
