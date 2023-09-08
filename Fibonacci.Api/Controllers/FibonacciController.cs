using Microsoft.AspNetCore.Mvc;

namespace Fibonacci.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        //Defining the HTTP GET action method to calculate Fibonacci
        [HttpGet("{n}")]
        public IActionResult GetFibonacci(int n)
        {
            //Check if index "n" is negative
            if (n < 0)
            {
                //If it is negative, it returns a BadRequest error with a message
                return BadRequest("The index must be a non-negative number.");
            }

            //Call the private CalculateFibonacci method to calculate the Fibonacci value
            int result = CalculateFibonacci(n);
            
            //Returns an HTTP 200 OK result along with the calculated Fibonacci value
            return Ok(result);
        }

        //Private method to calculate Fibonacci
        private int CalculateFibonacci(int n)
        {
            //Base case: If n is 0 or 1, returns n
            if (n <= 1)
            {
                return n;
            }

            //Initialization of variables to calculate Fibonacci
            int fib1 = 0;
            int fib2 = 1;
            int fib = 0;

            //Loop to calculate Fibonacci iteratively
            for (int i = 2; i <= n; i++)
            {
                fib = fib1 + fib2; //Calculate the new Fibonacci value
                fib1 = fib2; //Update the value of fib1
                fib2 = fib; //Update the value of fib2
            }

            //Returns the calculated Fibonacci value
            return fib;
        }
    }
}
