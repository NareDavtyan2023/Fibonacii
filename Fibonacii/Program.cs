using System.Threading.Channels;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write(Fib(10));
        }

            static int Fib(int x)
            {
                if (x == 0) return 0;

                int prev = 0;
                int next = 1;
                for (int i = 1; i < x; i++)
                {
                    int sum = prev + next;
                    prev = next;
                    next = sum;
                }
                return next;
            
            }
        
        
    }
}