using System.Collections.Generic;
using AutoMapper;
using GlucoControl.Application.Services;
using GlucoControl.NetCoreApi.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace GlucoControl.NetCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControlController : BaseController
    {
        IControlApplication _controlApplication;

        public ControlController(IControlApplication controlApplication, IMapper mapper) : base(mapper)
        {
            _controlApplication = controlApplication;
        }

        [HttpGet]
        public IEnumerable<Models.Control> Get()
        {
            // _controlApplication.Add
            return new List<Models.Control>();
        }
    }
}
