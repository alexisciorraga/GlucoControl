using AutoMapper;
using GlucoControl.Application.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GlucoControl.WebApi.Controllers
{
    [RoutePrefix("api/Control")]
    public class ControlController : ApiController
    {
        IControlApplication _controlApplication;
        IMapper _mapper;
        HttpResponseMessage _httpResponseMessage;

        public ControlController(IControlApplication controlApplication, IMapper mapper)
        {
            _controlApplication = controlApplication;
            _mapper = mapper;
        }

        [HttpPost]
        public HttpResponseMessage AddControl(Models.Control control)
        {
            try
            {
                var domainControl = _mapper.Map<Domain.Model.Data.Control.Control>(control);
                var controlInserted = _controlApplication.Add(domainControl);
                _httpResponseMessage = Request.CreateResponse(HttpStatusCode.OK, controlInserted);
            }
            catch (Exception exception)
            {
                _httpResponseMessage = Request.CreateResponse(HttpStatusCode.InternalServerError, exception);
            }

            return _httpResponseMessage;
        }

        [HttpGet]
        [Route("GetControl")]
        public HttpResponseMessage GetControl(Guid controlId)
        {
            try
            {
                var control = _controlApplication.GetById(controlId);
                _httpResponseMessage = Request.CreateResponse(HttpStatusCode.OK, control);
            }
            catch (Exception exception)
            {
                _httpResponseMessage = Request.CreateResponse(HttpStatusCode.InternalServerError, exception);
            }

            return _httpResponseMessage;
        }

        [HttpGet]
        [Route("GetAllControls")]
        public HttpResponseMessage GetAllControls()
        {
            try
            {
                var allControls = _controlApplication.GetAll();
                _httpResponseMessage = Request.CreateResponse(HttpStatusCode.OK, allControls);
            }
            catch (Exception exception)
            {
                _httpResponseMessage = Request.CreateResponse(HttpStatusCode.InternalServerError, exception);
            }

            return _httpResponseMessage;
        }

        [HttpGet]
        [Route("GetControlsByUserId")]
        public HttpResponseMessage GetControlsByUserId(Guid userId)
        {
            try
            {
                var control = _controlApplication.GetControlsByUserId(userId);
                _httpResponseMessage = Request.CreateResponse(HttpStatusCode.OK, control);
            }
            catch (Exception exception)
            {
                _httpResponseMessage = Request.CreateResponse(HttpStatusCode.InternalServerError, exception);
            }

            return _httpResponseMessage;
        }
    }
}