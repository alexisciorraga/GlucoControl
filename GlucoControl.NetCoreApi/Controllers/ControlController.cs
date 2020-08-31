using System;
using System.Collections.Generic;
using AutoMapper;
using GlucoControl.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace GlucoControl.NetCoreApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ControlController : ControllerBase
    {
        IControlApplication _controlApplication;
        IMapper _mapper;

        public ControlController(IMapper mapper, IControlApplication controlApplication)
        {
            _controlApplication = controlApplication;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<Models.Control> Get()
        {
            var domainControl = _controlApplication.GetAll();
            var apiControl = _mapper.Map<IEnumerable<Domain.Model.Data.Control.Control>, IEnumerable<Models.Control>>(domainControl);
            return apiControl;
        }

        [HttpPost]
        public void AddControl(Models.Control controlToAdd)
        {
            try
            {
                var controlDomain = new Domain.Model.Data.Control.Control
                {
                    ControlDate = controlToAdd.ControlDate,
                    GlucoseLevel = controlToAdd.GlucoseLevel,
                    InsulinAmount = controlToAdd.InsulinAmount,
                    ProvideInsulin = controlToAdd.ProvideInsulin,
                    UserId = controlToAdd.UserId
                };

                _controlApplication.Add(controlDomain);
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
