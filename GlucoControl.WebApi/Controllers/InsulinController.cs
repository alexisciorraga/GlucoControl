using AutoMapper;
using GlucoControl.Application.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GlucoControl.WebApi.Controllers
{
    [RoutePrefix("api/Insulin")]
    public class InsulinController : ApiController
    {
        IInsulinApplication _insulinApplication;
        IMapper _mapper;
        HttpResponseMessage _httpResponseMessage;

        public InsulinController(IInsulinApplication insulinApplication, IMapper mapper)
        {
            _insulinApplication = insulinApplication;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetAllInsulins")]
        public HttpResponseMessage GetAllInsulins()
        {
            try
            {
                var allInsulins = _insulinApplication.GetAll();
                _httpResponseMessage = Request.CreateResponse(HttpStatusCode.OK, allInsulins);
            }
            catch (Exception exception)
            {
                _httpResponseMessage = Request.CreateResponse(HttpStatusCode.InternalServerError, exception);
            }

            return _httpResponseMessage;
        }
    }
}
