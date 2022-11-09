using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Car.Entity;
using CarApi.Models;

namespace Car.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarInfosController : ControllerBase
    {
        private readonly CarContext _context;

        public CarInfosController(CarContext context)
        {
            _context = context;
        }

        // GET: api/CarInfos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarInfo>>> GetCarInfos()
        {
            return await _context.CarInfos.ToListAsync();
        }

        // GET: api/CarInfos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarInfo>> GetCarInfo(int id)
        {
            var carInfo = await _context.CarInfos.FindAsync(id);

            if (carInfo == null)
            {
                return NotFound();
            }

            return carInfo;
        }

        // PUT: api/CarInfos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarInfo(int id, CarInfo carInfo)
        {
            if (id != carInfo.Id)
            {
                return BadRequest();
            }

            _context.Entry(carInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarInfoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CarInfos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CarInfo>> PostCarInfo(CarInfo carInfo)
        {
            _context.CarInfos.Add(carInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarInfo", new { id = carInfo.Id }, carInfo);
        }

        // DELETE: api/CarInfos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CarInfo>> DeleteCarInfo(int id)
        {
            var carInfo = await _context.CarInfos.FindAsync(id);
            if (carInfo == null)
            {
                return NotFound();
            }

            _context.CarInfos.Remove(carInfo);
            await _context.SaveChangesAsync();

            return carInfo;
        }

        private bool CarInfoExists(int id)
        {
            return _context.CarInfos.Any(e => e.Id == id);
        }
    }
}
