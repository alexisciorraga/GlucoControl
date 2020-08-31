using AutoMapper;

namespace GlucoControl.App_Start
{
    public class AutomapperPresentationProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Domain.Model.Data.Control.Control, Models.Control>();
            CreateMap<Domain.Model.Data.Insulin.Insulin, Models.Insulin>();
            CreateMap<Domain.Model.Data.InsulinType.InsulinType, Models.InsulinType>();
            CreateMap<Domain.Model.Data.Role.Role, Models.Role>();
            CreateMap<Domain.Model.Data.User.User, Models.User>();
        }
    }
}