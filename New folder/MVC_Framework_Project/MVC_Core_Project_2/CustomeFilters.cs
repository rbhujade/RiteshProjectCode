using Microsoft.AspNetCore.Mvc.Filters;

namespace MVC_Core_Project_2
{
    public class CustomeFilters : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("On Action Executed.");
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("On Action Executing.");
        }
    }
}
