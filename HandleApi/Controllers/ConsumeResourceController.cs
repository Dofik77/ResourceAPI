using HandleApi.Interfaces;
using HandleApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumeResourceController : ControllerBase
    {
        ResourcesContext db;
        public ConsumeResourceController(ResourcesContext resourcesContext)
        {
            db = resourcesContext;
            if (!db.ElectroConsume.Any())
            {
                db.ElectroConsume.Add(
                    new ElectroConsume { 
                        DateOfPoint = new DateTime(24, 03, 2022),
                        Value = 5493, 
                        TransitionMethod = TransitionMethodEnum.Portal
                    }
                );

                db.SaveChanges();

            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResourcesConsumersContext>>> Get()
        {
            return await db.ResourcesConsumers.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ResourcesConsumersContext>> Get(int id)
        {
            ResourcesConsumersContext consumersContext = db.ResourcesConsumers.Select(x => x).FirstOrDefault();
        }
    }
}
