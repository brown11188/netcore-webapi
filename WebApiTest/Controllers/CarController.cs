using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApiTest.Common;
using WebApiTest.Models;

namespace WebApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        public CarController()
        {

        }

        // GET: api/Car
        [HttpGet]
        public IEnumerable<Car> GetCar()
        {
            return CarHelper.Cars;
        }

        // GET: api/Car/5
        [HttpGet("{id}", Name = "Get")]
        public Car GetCarById(int id)
        {
            return CarHelper.Cars.FirstOrDefault(x => x.Id == id);
        }

        // POST: api/Car
        [HttpPost]
        public ActionResult Create([FromBody] Car model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Wrong info.");
            }

            CarHelper.Cars.Add(new Car
            {
                Id = CarHelper.Cars.Count + 1,
                Name = model.Name,
                Model = model.Model,
                ModelYear = model.ModelYear
            });
            return Ok("Create new car successfully.");
        }

        // PUT: api/Car/5
        [HttpPut("{id}")]
        public void Update(int id, [FromBody] Car model)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
