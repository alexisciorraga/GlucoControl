using AutoMapper;

namespace GlucoControl.Domain.Logic.Configuration
{
    public class AutomapperDomainProfile : Profile
    {
        public AutomapperDomainProfile()
        {
            CreateMap<Repository.Models.User, Model.Data.User.User>().ReverseMap();

            CreateMap<Repository.Models.Role, Model.Data.Role.Role>().ReverseMap();

            CreateMap<Repository.Models.InsulinType, Model.Data.InsulinType.InsulinType>().ReverseMap();

            CreateMap<Repository.Models.Insulin, Model.Data.Insulin.Insulin>().ReverseMap();

            CreateMap<Repository.Models.Control, Model.Data.Control.Control>().ReverseMap();
        }
    }
}