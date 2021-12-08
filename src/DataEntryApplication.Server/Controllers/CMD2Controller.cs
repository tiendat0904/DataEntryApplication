using AutoMapper;
using DataEntryApplication.Server.Data.Entities;
using DataEntryApplication.Server.Services.Interfaces;
using DataEntryApplication.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataEntryApplication.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CMD2Controller : ControllerBase
    {
        private readonly ICmd2Service _cmd2Service;
        private readonly IMapper _mapper;

        public CMD2Controller(ICmd2Service cmd2Service, IMapper mapper)
        {
            _cmd2Service = cmd2Service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var values = await _cmd2Service.GetValuesOfCMD2();
            var valuesModel = _mapper.Map<IList<CMD2Model>>(values);
            return Ok(valuesModel);
        }

        [HttpPost("{mode:int}")]
        public async Task<IActionResult> Post([FromBody] IList<CMD2Model> values, int mode)
        {
            try
            {
                var valuesModel = _mapper.Map<IList<CMD2>>(values);
                await _cmd2Service.Save(valuesModel);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
    }
}
