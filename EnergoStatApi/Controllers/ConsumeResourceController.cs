using EnergoStatApi.Interfaces;
using EnergoStatApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnergoStatApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumeResourceController : ControllerBase
    {
        ElectroConsume electroFirst;
        ElectroConsume electroSecond;
        ElectroConsume electroThird;

        List<ElectroConsume> electroConsumesList = new List<ElectroConsume>();
        List<WhaterConsume>  whaterConsumesList = new List<WhaterConsume>();

        public ConsumeResourceController(ResourcesContext resourcesContext)
        {
            electroFirst = new ElectroConsume
            {
                DateOfPoint = new DateTime(24, 03, 2022),
                Value = 5493,
                TransitionMethod = TransitionMethodEnum.Portal
            };

            electroSecond = new ElectroConsume
            {
                DateOfPoint = new DateTime(24, 03, 2022),
                Value = 5493,
                TransitionMethod = TransitionMethodEnum.Portal
            };

            electroThird = new ElectroConsume
            {
                DateOfPoint = new DateTime(24, 03, 2022),
                Value = 5493,
                TransitionMethod = TransitionMethodEnum.Portal
            };

            electroConsumesList.Add(electroFirst);
            electroConsumesList.Add(electroSecond);
            electroConsumesList.Add(electroThird);
        }

        [HttpGet]
        public async Task<ActionResult<List<KeyValuePair<int,int>>>> GetElectroConsumeXY()
        {
            var resourceConumerXY = new ResourceConsumeXY(electroConsumesList);
        }

    }
}
