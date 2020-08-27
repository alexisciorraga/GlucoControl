using AutoMapper;
using System.Web.Mvc;

namespace GlucoControl.Controllers.Base
{
    public class BaseController : Controller
    {
        protected readonly IMapper _mapper;

        public BaseController(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}