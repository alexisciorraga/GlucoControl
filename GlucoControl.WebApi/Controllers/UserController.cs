using AutoMapper;
using GlucoControl.Application.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GlucoControl.WebApi.Controllers
{
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        IUserApplication _userApplication;
        IMapper _mapper;
        HttpResponseMessage _httpResponseMessage;

        public UserController(IUserApplication userApplication, IMapper mapper)
        {
            _userApplication = userApplication;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetUser")]
        public HttpResponseMessage GetUser(Guid userId)
        {
            try
            {
                var control = _userApplication.GetById(userId);
                _httpResponseMessage = Request.CreateResponse(HttpStatusCode.OK, control);
            }
            catch (Exception exception)
            {
                _httpResponseMessage = Request.CreateResponse(HttpStatusCode.InternalServerError, exception);
            }

            return _httpResponseMessage;
        }

        [HttpGet]
        [Route("GetAllUsers")]
        public HttpResponseMessage GetAllUsers()
        {
            try
            {
                var allUsers = _userApplication.GetAll();
                _httpResponseMessage = Request.CreateResponse(HttpStatusCode.OK, allUsers);
            }
            catch (Exception exception)
            {
                _httpResponseMessage = Request.CreateResponse(HttpStatusCode.InternalServerError, exception);
            }

            return _httpResponseMessage;
        }
    }
}
