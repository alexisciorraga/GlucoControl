using AutoMapper;
using GlucoControl.Application.Services;
using System.Web.Http;

namespace GlucoControl.WebApi.Controllers
{
    public class ControlController : ApiController
    {
        private IControlApplication _controlApplication;
        private IMapper _mapper;

        public ControlController(IControlApplication controlApplication, IMapper mapper)
        {
            _controlApplication = controlApplication;
            _mapper = mapper;
        }

        [HttpPost]
        public void AddControl(Models.Control control)
        {
            var test = _mapper.Map<Domain.Model.Data.Control.Control>(control);

            _controlApplication.Add(test);
        }
    }
}