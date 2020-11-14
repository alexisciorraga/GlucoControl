using AutoMapper;
using GlucoControl.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;

namespace GlucoControl.DotNetApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InsulinController : ControllerBase
    {
        private IInsulinApplication _insulinApplication;
        private IMapper _mapper;
        private HttpResponseMessage _httpResponseMessage;

        public InsulinController(IInsulinApplication insulinApplication, IMapper mapper)
        {
            _insulinApplication = insulinApplication;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetAllInsulins")]
        public ActionResult GetAllInsulins()
        {
            try
            {
                var allInsulins = _insulinApplication.GetAll();
                return Ok(allInsulins);
            }
            catch (Exception exception)
            {
                return NotFound(exception);
            }
        }
    }
}