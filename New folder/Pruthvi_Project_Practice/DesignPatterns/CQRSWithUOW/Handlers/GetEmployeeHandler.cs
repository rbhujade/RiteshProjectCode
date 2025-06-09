using CQRSWithUOW.Models;
using CQRSWithUOW.Queries;
using CQRSWithUOW.UOW;
using MediatR;

namespace CQRSWithUOW.Handlers
{
    public class GetEmployeeHandler : IRequestHandler<GetEmployeeQuery, IEnumerable<Employee>>
    {
        private readonly IUnitOfWork uow;
        public GetEmployeeHandler(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public async Task<IEnumerable<Employee>> Handle(GetEmployeeQuery request, CancellationToken cancellationToken)
        {
            var employees = await uow.EmployeeRepository.GetEmployeesAsync();
            return employees;
        }
    }
}
