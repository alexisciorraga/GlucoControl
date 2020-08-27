using AutoMapper;

namespace GlucoControl.App_Start
{
    public class AutomapperPresentationProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Domain.Model.Data.Formato.Formato, Models.Formato>();
            //CreateMap<Models.Master.ModelColumn, Domain.Model.Data.Master.ModelColumn>();

            //CreateMap<Domain.Model.Data.Reports.ReportGrupo, Models.Reports.ReportGrupo>();
        }
    }
}