using AutoMapper;
using GlucoControl.Application.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GlucoControl.WebApi.Controllers
{
    [RoutePrefix("api/Role")]
    public class RoleController : ApiController
    {
        IRoleApplication _roleApplication;
        IMapper _mapper;
        HttpResponseMessage _httpResponseMessage;

        public RoleController(IRoleApplication roleApplication, IMapper mapper)
        {
            _roleApplication = roleApplication;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetAllRoles")]
        public HttpResponseMessage GetAllRoles()
        {
            try
            {
                var allRoles = _roleApplication.GetAll();
                _httpResponseMessage = Request.CreateResponse(HttpStatusCode.OK, allRoles);
            }
            catch (Exception exception)
            {
                _httpResponseMessage = Request.CreateResponse(HttpStatusCode.InternalServerError, exception);
            }

            return _httpResponseMessage;
        }
    }
}
