using AutoMapper;
using GlucoControl.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;

namespace GlucoControl.DotNetApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ControlController : ControllerBase
    {
        private IControlApplication _controlApplication;
        private IMapper _mapper;
        private HttpResponseMessage _httpResponseMessage;

        public ControlController(IControlApplication controlApplication, IMapper mapper)
        {
            _controlApplication = controlApplication;
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult AddControl(Models.Control control)
        {
            try
            {
                var domainControl = _mapper.Map<Domain.Model.Data.Control.Control>(control);
                var controlInserted = _controlApplication.Add(domainControl);
                return Ok(controlInserted);
            }
            catch (Exception exception)
            {
                return NotFound(exception);
            }
        }

        [HttpGet]
        [Route("GetControl")]
        public ActionResult GetControl(Guid controlId)
        {
            try
            {
                var control = _controlApplication.GetById(controlId);
                return Ok(control);
            }
            catch (Exception exception)
            {
                return NotFound(exception);
            }
        }

        [HttpGet]
        [Route("GetAllControls")]
        public ActionResult GetAllControls()
        {
            try
            {
                var allControls = _controlApplication.GetAll();
                return Ok(allControls);
            }
            catch (Exception exception)
            {
                return NotFound(exception);
            }
        }

        [HttpGet]
        [Route("GetControlsByUserId")]
        public ActionResult GetControlsByUserId(Guid userId)
        {
            try
            {
                var control = _controlApplication.GetControlsByUserId(userId);
                return Ok(control);
            }
            catch (Exception exception)
            {
                return NotFound(exception);
            }
        }
    }
}