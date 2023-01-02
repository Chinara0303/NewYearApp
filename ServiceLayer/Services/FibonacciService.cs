using ServiceLayer.Services.Interfaces;
namespace ServiceLayer.Services
{
    public class FibonacciService : IFibonacciService
    {
        public ulong[] GetFibNums(int length)
        {
            // a b deyisenlerinin tipini ulong vermeyim duzgun deyil eslinde, explicit etmeliyem yoxsa.
            // Return typei ulong vermeli oldum eks halda uzunluq 45+ olduqda diopazonu asirdi arrayde
            // duzgun ededler cixarmirdi.Ona gore yazdim
            ulong a = 0;
            ulong b = 1;
            ulong[] fibNums = new ulong[length];
            fibNums[0] = a;
            fibNums[1] = b;
            for (int i = 2; i < length; i++)
            {
                ulong c = a + b;
                a = b;
                b = c;
                fibNums[i] = c;
            }
            return fibNums;
        }
    }
}
