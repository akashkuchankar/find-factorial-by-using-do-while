using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_factorial_by_using_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            int F = 1;
            {
                int i = 1;
                do
                {
                    F = F * i;
                  //  Console.WriteLine(F);
                    i++;
                } while (i <= N);

            }
            Console.WriteLine(F);
            
             
        }
    }
}
