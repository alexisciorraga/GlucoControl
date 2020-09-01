using AutoMapper;

namespace GlucoControl.WebApi
{
    public class AutomapperWebApiProfile : Profile
    {
        public AutomapperWebApiProfile()
        {
            CreateMap<Domain.Model.Data.Control.Control, Models.Control>();
            CreateMap<Models.Control, Domain.Model.Data.Control.Control>();

            CreateMap<Domain.Model.Data.Insulin.Insulin, Models.Insulin>();
            CreateMap<Models.Insulin, Domain.Model.Data.Insulin.Insulin>();

            CreateMap<Domain.Model.Data.InsulinType.InsulinType, Models.InsulinType>();
            CreateMap<Models.InsulinType, Domain.Model.Data.InsulinType.InsulinType>();

            CreateMap<Domain.Model.Data.Role.Role, Models.Role>();
            CreateMap<Models.Role, Domain.Model.Data.Role.Role>();

            CreateMap<Domain.Model.Data.User.User, Models.User>();
            CreateMap<Models.User, Domain.Model.Data.User.User>();
        }
    }
}