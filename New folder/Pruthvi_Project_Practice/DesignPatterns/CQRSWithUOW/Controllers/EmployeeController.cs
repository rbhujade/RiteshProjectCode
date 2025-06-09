using CQRSWithUOW.Commands;
using CQRSWithUOW.Data;
using CQRSWithUOW.Handlers;
using CQRSWithUOW.Models;
using CQRSWithUOW.Queries;
using CQRSWithUOW.Repository;
using CQRSWithUOW.UOW;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CQRSWithUOW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //private readonly DataContext dataContext;
        //private readonly IUnitOfWork uow;
        private readonly IMediator mediator;

        public EmployeeController(IMediator mediator)  //DataContext _dataContext, 
        {
            //dataContext = _dataContext;
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmplyee()
        {
            // UOW
            //var employees = await uow.EmployeeRepository.GetEmployeesAsync();
            //var employees = await dataContext.Employees.ToListAsync();

            //CQRS
            var query = new GetEmployeeQuery();
            var employees = await mediator.Send(query);
            return Ok(employees);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmplyee(Employee employee )
        {
            if (employee != null)
            {
                // UOW
                //uow.EmployeeRepository.AddEmplyee(employee);
                //await uow.SaveAsync();

                //await dataContext.Employees.AddAsync(employee);
                //await dataContext.SaveChangesAsync();

                // CQRS
                var query = new AddEmployeeCommand(employee.Id, employee.FirstName, employee.LastName, employee.Rating);
                var employees = await mediator.Send(query);
                return Ok(employees);
            }
            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            // UOW
            //if(uow.EmployeeRepository.DeleteEmplyee(id))            
            //{
            //    await uow.SaveAsync();
            //    return Ok(id);
            //}

            //CQRS
            var query = new DeleteEmployeeCommand(id);
            bool result = await mediator.Send(query);
            if(result)
                return Ok(result);

            return NotFound($"Employee with ID: {id} is not exists");

            //var tempEmp = await dataContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
            //if (tempEmp != null)
            //{
            //    dataContext.Employees.Remove(tempEmp);
            //    await dataContext.SaveChangesAsync();
            //    return Ok(id);
            //}
            //return BadRequest("Employee not found..");
        }
    }
}
