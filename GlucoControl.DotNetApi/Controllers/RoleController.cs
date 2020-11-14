using AutoMapper;
using GlucoControl.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GlucoControl.DotNetApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoleController : ControllerBase
    {
        private IRoleApplication _roleApplication;
        private IMapper _mapper;

        public RoleController(IRoleApplication roleApplication, IMapper mapper)
        {
            _roleApplication = roleApplication;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetAllRoles")]
        public ActionResult GetAllRoles()
        {
            try
            {
                var allRoles = _roleApplication.GetAll();
                return Ok(allRoles);
            }
            catch (Exception exception)
            {
                return NotFound(exception);
            }
        }
    }
}