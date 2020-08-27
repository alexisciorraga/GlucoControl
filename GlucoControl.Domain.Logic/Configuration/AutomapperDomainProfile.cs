using AutoMapper;

namespace GlucoControl.Domain.Logic.Configuration
{
    public class AutomapperDomainProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Repository.Model.User, Model.Data.User.User>();
            CreateMap<Model.Data.User.User, Repository.Model.User>();

            CreateMap<Repository.Model.Role, Model.Data.Role.Role>();
            CreateMap<Model.Data.Role.Role, Repository.Model.Role>();

            CreateMap<Repository.Model.InsulinType, Model.Data.InsulinType.InsulinType>();
            CreateMap<Model.Data.InsulinType.InsulinType, Repository.Model.InsulinType>();

            CreateMap<Repository.Model.Insulin, Model.Data.Insulin.Insulin>();
            CreateMap<Model.Data.Insulin.Insulin, Repository.Model.Insulin>();

            CreateMap<Repository.Model.Control, Model.Data.Control.Control>();
            CreateMap<Model.Data.Control.Control, Repository.Model.Control>();
        }
    }
}