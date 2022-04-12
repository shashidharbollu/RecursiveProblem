using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialProblem
{
    public class NormalFactorial
    {
        public void Factoriall()
        {
            double num, factorial = 1;
            Console.WriteLine("enter your number : ");
            num = Convert.ToDouble(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("cant find the factorial for a negative number");
            }
            else if (num <= 1)
            {
                Console.WriteLine("0! = 1");
            }
            else
            {
                for (double counter = num; counter >= 2; counter--)
                {
                    factorial = factorial * counter;
                }
                Console.WriteLine(factorial);
            }

        }
    }
}

