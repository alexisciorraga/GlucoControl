using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace GlucoControl.NetCoreApi.Controllers.Base
{
    public class BaseController : ControllerBase
    {
        protected readonly IMapper _mapper;

        public BaseController(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}
