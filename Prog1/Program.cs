using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prog1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, ctr,num1,num2;

            

            Console.Write("Input first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", num1,num2);

            for (num = num1; num <= num2; num++)
            {
                ctr = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
            Console.Write("\n");
            Console.ReadKey();
        }
    }
    
}
