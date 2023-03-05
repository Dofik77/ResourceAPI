using EnergoStatApi.Interfaces;
using EnergoStatApi.Models;
using EnergoStatApi.Models.ApiModels;
using EnergoStatApi.Service;
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
    public class ConsumptionResourceController : ControllerBase
    {
        ElectricConsumption electroFirst;
        ElectricConsumption electroSecond;
        ElectricConsumption electroThird;

        List<IResourceConsumption> electroConsumesList = new List<IResourceConsumption>();
        List<IResourceConsumption>  whaterConsumesList = new List<IResourceConsumption>();

        public ConsumptionResourceController()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                electroFirst = new ElectricConsumption
                {
                    Id = 1,
                    DateOfPoint = new DateTime(2022, 01, 24),
                    Value = 5123,
                    TransitionMethod = TransitionMethod.Portal
                };

                electroSecond = new ElectricConsumption
                {
                    Id = 2,
                    DateOfPoint = new DateTime(2022, 02, 24),
                    Value = 5451,
                    TransitionMethod = TransitionMethod.Portal
                };

                electroThird = new ElectricConsumption
                {
                    Id = 3,
                    DateOfPoint = new DateTime(2022, 03, 24),
                    Value = 5890,
                    TransitionMethod = TransitionMethod.Portal
                };

                db.Add(electroFirst);
                db.Add(electroSecond);
                db.Add(electroThird);
                db.SaveChanges();
            }

            electroConsumesList.Add(electroFirst);
            electroConsumesList.Add(electroSecond);
            electroConsumesList.Add(electroThird);
        }


        [HttpGet]
        public async Task<ActionResult<List<KeyValuePair<int, int>>>> GetElectroConsumeGraph()
        {
            var resourcesVector = new ConsumptionGraphService();
            var vectorData = resourcesVector.GetConsumptionGraph(electroConsumesList);
            return vectorData;
        }
    }
}
