namespace Calculator_CSharp.Controllers
{
    using Calculator_CSharp.Models;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index(Calculator calculator)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculate(Calculator calculator)
        {
            calculator.Result = CalculateResult(calculator);

            return RedirectToAction("Index", calculator);
        }

        private decimal CalculateResult(Calculator calculator)
        {
            var result = 0m;

            switch (calculator.Operator)
            {
                case "+":
                    result = calculator.LeftOperand + calculator.RightOperand;
                    break;
                case "-":
                    result = calculator.LeftOperand - calculator.RightOperand;
                    break;
                case "*":
                    result = calculator.LeftOperand * calculator.RightOperand;
                    break;
                case "/":
                    result = calculator.LeftOperand / calculator.RightOperand;
                    break;
                default:
                    result = 0;
                    break;
            }

            return result;
        }
    }
}