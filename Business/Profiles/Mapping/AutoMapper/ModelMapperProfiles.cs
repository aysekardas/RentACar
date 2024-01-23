using AutoMapper;
using Business.Dtos.Model;
using Business.Requests.Model;
using Business.Responses.Model;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Profiles.Mapping.AutoMapper
{
    public class ModelMapperProfiles :Profile
    {
        public ModelMapperProfiles()
        {
            CreateMap<AddModelRequest, Model>();

            CreateMap<Model, ModelListItemDto>();

            CreateMap<IList<Model>, GetModelListResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));

            
        }
    }
}
