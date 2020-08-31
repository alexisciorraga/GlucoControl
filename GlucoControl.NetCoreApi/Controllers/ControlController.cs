using System.Collections.Generic;
using AutoMapper;
using GlucoControl.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace GlucoControl.NetCoreApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ControlController : ControllerBase
    {
        IControlApplication _controlApplication;
        IMapper _mapper;

        public ControlController(IMapper mapper, IControlApplication controlApplication)
        {
            _controlApplication = controlApplication;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<Models.Control> Get()
        {
            return _mapper.Map<IEnumerable<Domain.Model.Data.Control.Control>, IEnumerable<Models.Control>>(_controlApplication.GetAll());
        }
    }
}
