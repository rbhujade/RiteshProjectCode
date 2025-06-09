using CQRSWithUOW.Models;
using MediatR;

namespace CQRSWithUOW.Commands
{
    public class AddEmployeeCommand(int id, string firstName, string lastName, int rating)
        : IRequest<Employee>
    {
        //public AddEmployeeCommand(int id, string firstName, string lastName, int rating)
        //{
        //    Id = id;
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Rating = rating;
        //}

        public int Id { get; set; } = id;
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set; } = lastName;
        public int Rating { get; set; } = rating;
    }
}
