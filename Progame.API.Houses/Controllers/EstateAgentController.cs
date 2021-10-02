using Microsoft.AspNetCore.Mvc;
using Progame.HousesAPIApp.BLL.Interfaces;
using Progame.HousesAPIApp.Common.DependencyInjections;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Progame.HousesAPIApp.Common.Entities;

namespace Progame.API.Houses.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class EstateAgentController: ControllerBase
    {
        public readonly IEstateAgentService _estateAgentService;

        public EstateAgentController()
        {
            _estateAgentService = DependenciesResolver.Kernel.GetService<IEstateAgentService>();
        }

        [HttpGet]
        public ActionResult<IEnumerable<EstateAgent>> Get()
        {
            return _estateAgentService.GetAll().ToList();
        }

        [HttpGet("(id)")]
        public ActionResult<EstateAgent> Get(int id)
        {
            var data = _estateAgentService.GetAll();
            if (data != null)
            {
                return data.Where(b => b.Id == id).FirstOrDefault();
            }
            else
            {
                return BadRequest();
            }
            
        }

        [HttpPost]
        public ActionResult<EstateAgent> Post(EstateAgent estateAgent)
        {
            if (estateAgent is null)
            {
                return BadRequest();
            }
            else
            {
                _estateAgentService.Add(estateAgent);
                return Ok(estateAgent);
            }
        }

        [HttpDelete("id")]
        public ActionResult<EstateAgent> Delete(int id)
        {
            var estateAgent = _estateAgentService.GetAll().Where(b => b.Id == id).FirstOrDefault();

            if (estateAgent is null)
            {
                return BadRequest();
            }
            else
            {
                _estateAgentService.Delete(estateAgent);
                return Ok(estateAgent);
            }
        }

        [HttpPut]
        public ActionResult<EstateAgent> Put(EstateAgent estateAgent)
        {
            if (estateAgent is null)
            {
                return BadRequest();
            }
            if (!_estateAgentService.GetAll().Any(b => b.Id == estateAgent.Id))
            {
                return NotFound();
            }

            _estateAgentService.Update(estateAgent);

            return Ok(estateAgent);

        }
    }
}

