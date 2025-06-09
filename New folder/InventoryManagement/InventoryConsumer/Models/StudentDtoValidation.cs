using FluentValidation;

namespace InventoryConsumer.Models
{
    public class StudentDtoValidation : AbstractValidator<StudentDto>
    {
        public StudentDtoValidation() 
        {
            RuleSet("all", () => { 
                RuleFor(r=>r.Id).NotNull().WithMessage("Id could not be null.");
                RuleFor(r => r.FirstName).NotNull().WithMessage("First Namecould not be null.");
                RuleFor(r => r.LastName).NotNull().WithMessage("Last Name could not be null.");
            });
        }
    }
}
