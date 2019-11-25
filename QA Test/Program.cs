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

            //Console.WriteLine("Unesi prvi broj: ");
            //double broj1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Unesi drugi broj: ");
            //double broj2 = Convert.ToDouble(Console.ReadLine());
            //double result = Zadatak1(broj1, broj2);
            //Console.WriteLine("Rezultat je {0}", result);
            //            Korisnik unosi brojeve sa tastature, sve dok ne upiše broj manji od 0.
            //Sve te brojeve smeštati u listu brojeva. Napisati program koji će da ispiše:
            //Sumu svih unetih brojeva
            //Aritmetičku sredinu svih unetih brojeva
            //Sortiranu listu brojeva, od najvećeg ka najmanjem broju
            //Zadatak2();
//            Korisnik unosi neki tekst sa tastature. Napisati klasu StringFunctions, 
            //koja će da sadrži metode koji na unetom tekstu:
//            Broji reči(metod CountWords)
//Broji razmake(metod CountSpaces)
//Ispisuje najkraću reč(metod ShortestWord)
//Ispisuje najdužu reč(metod LongestWord)

            
            string tekst = "Ovo je neki tekst.";
            int count1 = StringFunctions.CountWords(tekst);
            int count2=StringFunctions.CountSpaces(tekst);
            Console.WriteLine("Broj reci je: {0}", count1);

            Console.WriteLine("Broj razmaka je: {0}",count2);
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
        static void Zadatak2()
        {
            List<int> lista = new List<int>();
            bool stayinloop = true;
            string userentry;
            int entry;
            do
            {
                Console.WriteLine("Unesi broj, za prekid unesi broj manji od nule");
                userentry = Console.ReadLine();
                entry = Convert.ToInt32(userentry);

                if (entry<0)
                {
                    stayinloop = false;
                    break;
                }
                lista.Add(entry);
            } while (stayinloop);
            Console.WriteLine("Suma svih unetih brojeva je: {0}", SumOfList(lista));
            Console.WriteLine("Aritmeticka sredina unetih brojeva je: {0}", MeanOfList(lista));
            Console.WriteLine("Lista brojeva od najmanjeg ka najvecem broju: ");
            lista.Sort();
            foreach(int i in lista)
            {
                Console.WriteLine(i);
            }
        }
        static int SumOfList(List<int> anylist)
        {

            int sum = 0;
            foreach (int i in anylist)
            {
                sum = sum + i;
            }
            return sum;
        }
        static int MeanOfList(List <int> anylist)
        {
            int sum = 0;
            int result = 0;
            foreach(int i in anylist)
            {
                sum = sum + i;
                
            }
            result = sum / anylist.Count();
            return result;
        }
    }
}
