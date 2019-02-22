using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0, total = 0, ciclos = 0, dobles = 0;
            string continuar = "s";
            string jugarsela = "";

            while (continuar == "s" && ciclos != 3)
            {
                dado1 = aleatorio.Next(1, 13);
                total += dado1;
                ciclos += 1;
                if (dado1 == 10 || dobles == 10)
                {
                    dobles = 10;
                    if (dado1 == 12 && dobles == 10)
                    {
                        Console.WriteLine("*** GANO ***");
                        continuar = "n";
                    }
                    else
                    {
                        Console.WriteLine("Su dado es =" + dado1);
                        Console.WriteLine("total = " + total);
                        Console.Write("Desea continuar (s/n):");
                        continuar = Console.ReadLine();
                    }
                }
                else
                {

                    Console.WriteLine("Su dado es =" + dado1);
                    Console.WriteLine("total = " + total);
                    Console.Write("Desea continuar (s/n):");
                    continuar = Console.ReadLine();
                }

            }
            Console.WriteLine("Es su tercer ciclo, SI SACA IMPAR PIERDE ");
            Console.Write("Precione (c) si desea continuar : ");
            jugarsela = Console.ReadLine();
            while (ciclos == 3 && (continuar == "s" && jugarsela == "c"))
            {
                dado1 = aleatorio.Next(1, 13);
                total += dado1;
                if (dado1 % 2 == 0)
                {
                    if (dado1 == 10 || dobles == 12)
                    {
                        dobles = 12;
                        if (dado1 == 12 && dobles == 12)
                        {
                            Console.WriteLine("*** GANO ***");
                            continuar = "n";
                        }
                        else
                        {
                            Console.WriteLine("Su dado es =" + dado1);
                            Console.WriteLine("total = " + total);
                            Console.Write("Desea continuar (s/n):");
                            continuar = Console.ReadLine();
                        }
                    }
                    else if (total >= 100)
                    {
                        Console.WriteLine("*** GANO ***");
                        continuar = "n";
                    }
                    else
                    {
                        Console.WriteLine("Su dado es =" + dado1);
                        Console.WriteLine("total = " + total);
                        Console.Write("Desea continuar (s/n):");
                        continuar = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("### PERDIO ###");
                    Console.WriteLine("Su dado fue = " + dado1);
                    continuar = "n";
                }


            }

            Console.WriteLine("Gracias por participar");
            Console.WriteLine("Su total fue = " + total + " Puntos");
        }
    }
}
