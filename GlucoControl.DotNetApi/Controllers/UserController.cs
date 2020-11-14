using AutoMapper;
using GlucoControl.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;

namespace GlucoControl.DotNetApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserApplication _userApplication;
        private IMapper _mapper;
        private HttpResponseMessage _httpResponseMessage;

        public UserController(IUserApplication userApplication, IMapper mapper)
        {
            _userApplication = userApplication;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetUser")]
        public ActionResult GetUser(Guid userId)
        {
            try
            {
                var control = _userApplication.GetById(userId);
                return Ok(control);
            }
            catch (Exception exception)
            {
                return NotFound(exception);
            }
        }

        [HttpGet]
        [Route("GetAllUsers")]
        public ActionResult GetAllUsers()
        {
            try
            {
                var allUsers = _userApplication.GetAll();
                return Ok(allUsers);
            }
            catch (Exception exception)
            {
                return NotFound(exception);
            }
        }

        [HttpGet]
        [Route("Login")]
        public ActionResult Login(string username, string password)
        {
            try
            {
                var allUsers = _userApplication.Login(username, password);
                return Ok(allUsers);
            }
            catch (Exception exception)
            {
                return NotFound(exception);
            }
        }
    }
}