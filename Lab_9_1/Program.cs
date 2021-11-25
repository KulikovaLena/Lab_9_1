using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vas privetstvuet kalkulytor!");
            try
            {
                Console.Write("Vvedite zeloe chislo x -");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Vvedite zeloe chislo y -");
                int y = int.Parse(Console.ReadLine());
                double a;
                int n;
                Console.Write("Vvedite kod operacii\n  1   +\n  2   -\n  3   *\n  4   /\n Vash vibor: ");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        {
                            a = x + y;
                            Console.WriteLine(" Rezultat = {0}", a);
                            break;
                        }
                    case 2:
                        {
                            a = x - y;
                            Console.WriteLine(" Rezultat = {0}", a);
                            break;
                        }
                    case 3:
                        {
                            a = x * y;
                            Console.WriteLine(" Rezultat = {0}", a);
                            break;
                        }
                    case 4:
                        {
                            try
                            {
                                a = x / y;
                                Console.WriteLine(" Rezultat = {0}", a);
                            }
                            catch
                            {
                                Console.WriteLine("delenie na 0 ne dopuskaetsy");
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("net operacii c ukazannim nomerom");
                            break;
                        }
                }
            }
            catch
            {
                Console.WriteLine("Oshibka! Vhodnay stroka imela nevernii format");
            }
            Console.ReadLine();
        }
    }
}
