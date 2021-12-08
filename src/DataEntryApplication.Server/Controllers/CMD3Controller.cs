using AutoMapper;
using DataEntryApplication.Server.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataEntryApplication.Server.Controllers
{
    public class CMD3Controller : ControllerBase
    {
        private readonly ICmd3Service _cmd3Service;
        private readonly IMapper _mapper;

        public CMD3Controller(ICmd3Service cmd3Service, IMapper mapper)
        {
            _cmd3Service = cmd3Service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var values = await _cmd3Service.GetValuesOfCMD3();
            //var valuesModel = _mapper.Map<IList<CMD2Model>>(values);
            //var a = new
            //{
                
            //}
            return Ok(values);
        }
    }
}