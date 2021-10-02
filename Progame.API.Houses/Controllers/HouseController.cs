using Microsoft.AspNetCore.Mvc;
using Progame.HousesAPIApp.BLL.Interfaces;
using Progame.HousesAPIApp.Common.DependencyInjections;
using Progame.HousesAPIApp.Common.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Progame.API.Houses.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class HouseController : ControllerBase
    {
        public readonly IHouseService _houseService;

        public HouseController()
        {
            _houseService = DependenciesResolver.Kernel.GetService<IHouseService>();
        }

        [HttpGet]
        public ActionResult<IEnumerable<House>> Get()
        {
            return _houseService.GetAll().ToList();
        }

        [HttpGet("(id)")]
        public ActionResult<House> Get(int id)
        {
            var data = _houseService.GetAll();
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
        public ActionResult<House> Post(House house)
        {
            if (house is null)
            {
                return BadRequest();
            }
            else
            {
                _houseService.Add(house);
                return Ok(house);
            }
        }

        [HttpDelete("id")]
        public ActionResult<House> Delete(int id)
        {
            var house = _houseService.GetAll().Where(b => b.Id == id).FirstOrDefault();

            if (house is null)
            {
                return BadRequest();
            }
            else
            {
                _houseService.Delete(house);
                return Ok(house);
            }
        }

        [HttpPut]
        public ActionResult<House> Put(House house)
        {
            if (house is null)
            {
                return BadRequest();
            }
            if (!_houseService.GetAll().Any(b => b.Id == house.Id))
            {
                return NotFound();
            }

            _houseService.Update(house);

            return Ok(house);
        }
    }
}
