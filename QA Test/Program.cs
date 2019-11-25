using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Korisnik unosi dva broja sa tastature. Napisati program tako da:

            //Ukoliko su oba broja parna, pomnožiti ih i ispisati rezultat
            //Ukoliko su oba broja neparna, sabrati ih, i ispisati rezultat
            //Ukoliko je jedan paran, a jedan neparan, podeliti veći broj manjim

            Console.WriteLine("Unesi prvi broj: ");
            double broj1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesi drugi broj: ");
            double broj2 = Convert.ToDouble(Console.ReadLine());
            double result = Zadatak1(broj1, broj2);
            Console.WriteLine("Rezultat je {0}", result);
            Console.ReadKey();

        }
        static double Zadatak1(double num1, double num2)
        {
            double result=0;
            if (num1 % 2 == 0 && num2 % 2 == 0)
            {
                result = num1 * num2;
            }
            if (num1 % 2 != 0 && num2 % 2 != 0)
            {
                result = num1 + num2;
            }
            if (num1 % 2 != 0 && num2 % 2 == 0)
            {
                if (num1 > num2)
                {
                    result = num1 / num2;
                }
                else
                    result = num2 / num1;
            }
            if (num1 % 2 == 0 && num2 % 2 != 0)
            {
                if (num1 > num2)
                {
                    result = num1 / num2;
                }
                else
                    result = num2 / num1;
            }
            return result;

        }
    }
}
