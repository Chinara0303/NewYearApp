using ServiceLayer.Services;

namespace NewYearApp.Controller
{
    public class FibonacciController
    {
        private readonly FibonacciService _service;
        public FibonacciController() => _service= new FibonacciService();
        
        public void GetFibNums()
        {
            Console.WriteLine("Specify the length");
    Return: string lengthStr = Console.ReadLine();
            int length;
            bool IsParseLengthStr = int.TryParse(lengthStr, out length);
            if(!IsParseLengthStr)
            {
                Console.WriteLine("Enter a valid number");
                lengthStr = Console.ReadLine();
                goto Return;
            }
            var res = _service.GetFibNums(length);
            foreach (var item in res)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
