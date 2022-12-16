using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Car.Entity;
using CarApi.Models;
using Car.Services;

namespace Car.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }
        // GET: api/Employees
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var allEmployees = _employeeService.GetAll();
                return Ok(allEmployees);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        // GET: api/Employees/5
        [HttpGet("{id}")]
        public IActionResult GetDetail(int id)
        {
            var employee = _employeeService.GetDetail(id);
            return Ok(employee);
        }
        // PUT: api/Employees/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Employee employee)
        {
            _employeeService.Update(id, employee);
            return Ok();
        }

        // DELETE: api/Employees/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _employeeService.Delete(id);
            return Ok();
        }
    }
}
