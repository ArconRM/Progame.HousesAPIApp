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

        public class OwnerController : ControllerBase
        {
            public readonly IOwnerService _ownerService;

            public OwnerController()
            {
                _ownerService = DependenciesResolver.Kernel.GetService<IOwnerService>();
            }

            [HttpGet]
            public ActionResult<IEnumerable<Owner>> Get()
            {
                return _ownerService.GetAll().ToList();
            }

            [HttpGet("(id)")]
            public ActionResult<Owner> Get(int id)
            {
                var data = _ownerService.GetAll();
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
            public ActionResult<Owner> Post(Owner owner)
            {
                if (owner is null)
                {
                    return BadRequest();
                }
                else
                {
                    _ownerService.Add(owner);
                    return Ok(owner);
                }
            }

            [HttpDelete("id")]
            public ActionResult<Owner> Delete(int id)
            {
                var owner = _ownerService.GetAll().Where(b => b.Id == id).FirstOrDefault();

                if (owner is null)
                {
                    return BadRequest();
                }
                else
                {
                    _ownerService.Delete(owner);
                    return Ok(owner);
                }
            }

            [HttpPut]
            public ActionResult<Owner> Put(Owner owner)
            {
                if (owner is null)
                {
                    return BadRequest();
                }
                if (!_ownerService.GetAll().Any(b => b.Id == owner.Id))
                {
                    return NotFound();
                }

                _ownerService.Update(owner);

                return Ok(owner);

            }
        }
    }
