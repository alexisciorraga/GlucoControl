using AutoMapper;

namespace GlucoControl.DotNetApi.AutoMapperProfiles
{
    public class InsulinProfile : Profile
    {
        public InsulinProfile()
        {
            CreateMap<Domain.Model.Data.Insulin.Insulin, Models.Insulin>();
        }
    }
}
