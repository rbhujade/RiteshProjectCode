using CQRSWithUOW.Models;
using MediatR;

namespace CQRSWithUOW.Queries
{
    public class GetEmployeeQuery : IRequest<IEnumerable<Employee>>
    {
    }
}
