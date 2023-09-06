using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3EJ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string edad;
            int age, ace, total;
            Console.WriteLine("Es mayor de edad?");
            Console.WriteLine("A)Si");
            Console.WriteLine("B)No");
            edad = Console.ReadLine();
            switch (edad)
            {
                case "A":
                    Console.WriteLine("Cuantos años tienes?");
                    age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Cuantas adivinanzas acertó?");
                    ace = int.Parse(Console.ReadLine());
                    if (ace >= 3)
                    {
                        total = (50 + (5 * age) + (2 * ace));
                        Console.WriteLine("El monto final que ganó es de " + total + " soles");
                    }
                    else
                    {
                        total = (30 + (5 * age) + (2 * ace));
                        Console.WriteLine("El monto final que ganó es de " + total + " soles");
                    }
                    break;
                case "B":
                    Console.WriteLine("Cuantos años tienes?");
                    age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Cuantas adivinanzas acertó?");
                    ace = int.Parse(Console.ReadLine());
                    if (ace >= 3)
                    {
                        total = (80 + (5 * age) + (2 * ace));
                        Console.WriteLine("El monto final que ganó es de " + total + " soles");
                    }
                    else
                    {
                        total = (50 + (5 * age) + (2 * ace));
                        Console.WriteLine("El monto final que ganó es de " + total + " soles");
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
