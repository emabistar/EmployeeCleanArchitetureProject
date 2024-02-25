using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationEmployee.Contracts;
using DomainEmployee.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendEmployeeAPi.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {


        private readonly IEmployee _employee;

        public EmployeeController(IEmployee employee)
        {
            this._employee = employee;
        }

        // GET: api/<EmployeeController>/
        [HttpGet]
        public async  Task<IActionResult> Get()
        {
            var data = await _employee.GetAllAsync();
            return Ok(data);
        }
        // Get api/<EmployeeController>/4
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _employee.GetByIdAsync(id);
            return Ok(data);
        }
        //Post api/<EmployeeController>
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Employee employeeDto)
        {
            var result = await _employee.AddAsync(employeeDto);
            return Ok(result);
        }
        //Put api<EmployeeController>/4
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Employee employeeDto)
        {
            var result = await _employee.UpdateAsync(employeeDto);
            return Ok(result);
        }
        //Delete api<EmployeeController>/4
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _employee.DeleteAsync(id);
            return Ok(result);
        }
    }
}

