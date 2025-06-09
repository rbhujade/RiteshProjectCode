using CQRSWithUOW.Commands;
using CQRSWithUOW.Models;
using CQRSWithUOW.UOW;
using MediatR;

namespace CQRSWithUOW.Handlers
{
    public class AddEmployeeHandler : IRequestHandler<AddEmployeeCommand, Employee>
    {
        private readonly IUnitOfWork uow;
        public AddEmployeeHandler(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public async Task<Employee> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            Employee employee = new Employee
            {
                Id = request.Id,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Rating = request.Rating
            };

            var result = await uow.EmployeeRepository.AddEmplyee(employee);
            await uow.SaveAsync();
            return result;
        }
    }
}
