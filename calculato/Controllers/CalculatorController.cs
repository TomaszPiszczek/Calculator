using Microsoft.AspNetCore.Mvc;

namespace calculato.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(double num1, double num2, string operation)
        {
            double result = 0;

            switch (operation)
            {
                case "Add":
                    result = num1 + num2;
                    break;
                case "Subtract":
                    result = num1 - num2;
                    break;
                case "Multiply":
                    result = num1 * num2;
                    break;
                case "Divide":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        ViewBag.Error = "Cannot divide by zero";
                        return View("Index");
                    }
                    break;
            }

            ViewBag.Result = result;
            return View("Index");
        }
    }
}
