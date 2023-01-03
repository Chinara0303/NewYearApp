using ServiceLayer.Helpers.Constants;
using ServiceLayer.Services.Interfaces;

namespace ServiceLayer.Services
{
    public class CalculateService : ICalculateService
    {
        public string Calculation(double num1, double num2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return (num1 + num2).ToString();
                case "-":
                    return (num1 - num2).ToString();
                case "*":
                    return (num1 * num2).ToString();
                case "/":
                    return (num1 / num2).ToString();
                default:
                    return Messages.OperateError;
            }
        }
    }
}
