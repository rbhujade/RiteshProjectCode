using MediatR;

namespace CQRSWithUOW.Commands
{
    public class DeleteEmployeeCommand : IRequest<bool>
    {
        public DeleteEmployeeCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
