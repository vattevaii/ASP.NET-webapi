using asp.net_folder.Models;
using asp.net_folder.Services;
using Microsoft.AspNetCore.Mvc;

namespace Namespace_asp.net_folder.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
   public EmployeeController() { }

   // Get all employees
   [HttpGet]
   public ActionResult<IEnumerable<Employee>> Get()
   {
      return EmployeeService.GetAll();
   }

   // Get employee by id
   [HttpGet("{id}")]
   public IActionResult Get(int id)
   {
      var employee = EmployeeService.GetById(id);
      if (employee == null)
         return NotFound();
      return Ok(employee);
   }

   // Add employee
   [HttpPost]
   public IActionResult Add(Employee employee)
   {
      var emp = EmployeeService.Add(employee);
      // "Get" is a method on the controller that returns a single employee based on the id passed in the route
      // Get(int id) is the method used to create location in the response header
      // created emp is also returned along
      return CreatedAtAction("Get", new { id = emp.Id }, emp);
   }

   // Update employee
   [HttpPut("{id}")]
   public IActionResult Update(int id, Employee employee)
   {
      if (employee.Id != id)
         return BadRequest();

      var emp = EmployeeService.GetById(id);
      if (emp == null)
         return NotFound();

      EmployeeService.Update(employee);
      return NoContent();
   }
   // Delete employee
   // [HttpDelete("{id}")]
   // public IActionResult Delete(int id)
   // {
   //    var emp = EmployeeService.GetById(id);
   //    if (emp == null)
   //       return NotFound();
   //    EmployeeService.Delete(id);
   //    return NoContent();
   // }
   // Check if employee on holiday
   [HttpGet("{id}/holiday")]
   public IActionResult OnHoliday(int id)
   {
      var emp = EmployeeService.GetById(id);
      if (emp == null)
         return NotFound();
      return Ok(emp.OnHoliday);
   }
   // Update employee holiday status
   [HttpPut("{id}/holiday")]
   public IActionResult UpdateHoliday(int id)
   {
      // service method to update holiday status then return updated employee or null if not found
      var employee = EmployeeService.UpdateHoliday(id);
      if (employee == null)
         return NotFound();
      return Ok(employee);
   }
}