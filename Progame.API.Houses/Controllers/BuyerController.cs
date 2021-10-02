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

    public class BuyerController : ControllerBase
    {
        public readonly IBuyerService _buyerService;

        public BuyerController()
        {
            _buyerService = DependenciesResolver.Kernel.GetService<IBuyerService>();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Buyer>> Get()
        {
            var data = _buyerService.GetAll();
            if (data != null)
            {
                return data.ToList();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("(id)")]
        public ActionResult<Buyer> Get(int id)
        {
            var data = _buyerService.GetAll();
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
        public ActionResult<Buyer> Post(Buyer buyer)
        {
            //Invoke-RestMethod https://localhost:44381/api/buyer -Method POST -Body (@{Fullname = "Bob"; Email = "2323"; PhoneNumber="2323"; Age = 5} | ConvertTo-Json) -ContentType "application/json; charset=utf-8"
            if (buyer is null)
            {
                return BadRequest();
            }
            else
            {
                _buyerService.Add(buyer);
                return Ok(buyer);
            }
        }

        [HttpDelete("id")]
        public ActionResult<Buyer> Delete(int id)
        {
            var buyer = _buyerService.GetAll().Where(b => b.Id == id).FirstOrDefault();

            if (buyer is null)
            {
                return BadRequest();
            }
            else
            {
                _buyerService.Delete(buyer);
                return Ok(buyer);
            }
        }

        [HttpPut]
        public ActionResult<Buyer> Put(Buyer buyer)
        {
            if (buyer is null)
            {
                return BadRequest();
            }
            if (!_buyerService.GetAll().Any(b => b.Id == buyer.Id))
            {
                return NotFound();
            }

            _buyerService.Update(buyer);

            return Ok(buyer);

        }
    }
}
