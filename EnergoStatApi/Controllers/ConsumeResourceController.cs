using EnergoStatApi.DAL;
using EnergoStatApi.DAL.Interfaces;
using EnergoStatApi.Domain.Entity;
using EnergoStatApi.Domain.Enum;
using EnergoStatApi.Domain.Interface;
using EnergoStatApi.Domain.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnergoStatApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumptionResourceController : ControllerBase
    {
        private readonly IElectricConsumeRepository _electricRepository;

        public ConsumptionResourceController(IElectricConsumeRepository electricRepository)
        {
            _electricRepository = electricRepository;
        }

        [HttpGet("GetElectroConsumeGraph")]
        public async Task<ActionResult<List<KeyValuePair<int, double>>>> GetElectroConsumeGraph()
        {
            var resourcesVector = new ConsumptionGraphService();
            var response =  await _electricRepository.Select();

            var vectorData = await resourcesVector.GetConsumptionGraphService(response); 
            
            return vectorData; 
        } 

        [HttpPost("PostConsumeData")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> PostConsumeData(ElectricConsumptionModel electricConsumptionModel)
        {
            _electricRepository.Created(electricConsumptionModel);
            return true; 
        }
    }
}
