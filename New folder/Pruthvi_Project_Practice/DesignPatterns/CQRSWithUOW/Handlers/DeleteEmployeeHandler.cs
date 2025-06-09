using Azure.Core;
using CQRSWithUOW.Commands;
using CQRSWithUOW.UOW;
using MediatR;

namespace CQRSWithUOW.Handlers
{
    public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployeeCommand, bool>
    {
        private readonly IUnitOfWork uow;

        public DeleteEmployeeHandler(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public Task<bool> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            uow.EmployeeRepository.DeleteEmplyee(request.Id);
            return uow.SaveAsync();
        }
    }
}
