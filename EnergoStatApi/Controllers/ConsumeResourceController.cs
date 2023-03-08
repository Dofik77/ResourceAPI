using EnergoStatApi.DAL.Interfaces;
using EnergoStatApi.Domain.Entity;
using EnergoStatApi.Domain.Interface;
using EnergoStatApi.Domain.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EnergoStatApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumptionResourceController : ControllerBase
    {
        private readonly IElectricConsumeRepository _electricRepository;

        private ConsumptionResourceController(IElectricConsumeRepository electricRepository)
        {
            _electricRepository = electricRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<KeyValuePair<int, double>>>> GetElectroConsumeGraph()
        {
            var resourcesVector = new ConsumptionGraphService();
            var response =  await _electricRepository.Select();

            var vectorData = resourcesVector.GetConsumptionGraphService(response); 
            return vectorData;
        }

        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public async Task<ActionResult> PostConsumeData()
        {
            var result = GetConsumeData.UploadFile();
            return Ok(result);
        }
    }

    public class GetConsumeData
    {
        public static string UploadFile()
        {
            return "Ok";
        }
    }
}
