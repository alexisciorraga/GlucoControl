using AutoMapper;
using GlucoControl.Application.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GlucoControl.WebApi.Controllers
{
    [RoutePrefix("api/InsulinType")]
    public class InsulinTypeController : ApiController
    {
        IInsulinTypeApplication _insulinTypeApplication;
        IMapper _mapper;
        HttpResponseMessage _httpResponseMessage;

        public InsulinTypeController(IInsulinTypeApplication insulinTypeApplication, IMapper mapper)
        {
            _insulinTypeApplication = insulinTypeApplication;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetAllInsulinTypes")]
        public HttpResponseMessage GetAllInsulinTypes()
        {
            try
            {
                var allInsulinTypes = _insulinTypeApplication.GetAll();
                _httpResponseMessage = Request.CreateResponse(HttpStatusCode.OK, allInsulinTypes);
            }
            catch (Exception exception)
            {
                _httpResponseMessage = Request.CreateResponse(HttpStatusCode.InternalServerError, exception);
            }

            return _httpResponseMessage;
        }
    }
}
