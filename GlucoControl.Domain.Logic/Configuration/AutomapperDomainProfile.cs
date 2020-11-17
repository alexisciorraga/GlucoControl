using AutoMapper;

namespace GlucoControl.Domain.Logic.Configuration
{
    public class AutomapperDomainProfile : Profile
    {
        public AutomapperDomainProfile()
        {
            CreateMap<Repository.Models.User, Model.Data.User.User>();
            CreateMap<Model.Data.User.User, Repository.Models.User>();

            CreateMap<Repository.Models.Role, Model.Data.Role.Role>();
            CreateMap<Model.Data.Role.Role, Repository.Models.Role>();

            CreateMap<Repository.Models.InsulinType, Model.Data.InsulinType.InsulinType>();
            CreateMap<Model.Data.InsulinType.InsulinType, Repository.Models.InsulinType>();

            CreateMap<Repository.Models.Insulin, Model.Data.Insulin.Insulin>();
            CreateMap<Model.Data.Insulin.Insulin, Repository.Models.Insulin>();

            CreateMap<Repository.Models.Control, Model.Data.Control.Control>();
            CreateMap<Model.Data.Control.Control, Repository.Models.Control>();
        }
    }
}