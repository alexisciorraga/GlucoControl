using AutoMapper;
using GlucoControl.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;

namespace GlucoControl.DotNetApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InsulinTypeController : ControllerBase
    {
        private IInsulinTypeApplication _insulinTypeApplication;
        private IMapper _mapper;
        private HttpResponseMessage _httpResponseMessage;

        public InsulinTypeController(IInsulinTypeApplication insulinTypeApplication, IMapper mapper)
        {
            _insulinTypeApplication = insulinTypeApplication;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetAllInsulinTypes")]
        public ActionResult GetAllInsulinTypes()
        {
            try
            {
                var allInsulinTypes = _insulinTypeApplication.GetAll();
                return Ok(allInsulinTypes);
            }
            catch (Exception exception)
            {
                return NotFound(exception);
            }
        }
    }
}