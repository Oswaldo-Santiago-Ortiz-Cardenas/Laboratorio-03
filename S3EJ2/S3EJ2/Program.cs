using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace S3EJ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cat;
            int dias, desayuno, total,final;
            Console.WriteLine("Ingrese la categoría de Hotel al que se quiere hospedar");
            Console.WriteLine("A)3 estrellas");
            Console.WriteLine("B)5 estrellas");
            cat = Console.ReadLine();
            switch (cat)
            {
                case "A":
                    Console.WriteLine("Cuantos días desea hospedarse?");
                    dias = int.Parse(Console.ReadLine());
                    if (dias <= 5)
                    {
                        desayuno = (7 * dias);
                        total = 100 * dias;
                        final = total + desayuno;
                        Console.WriteLine("El pago que debe realizar es de " + final + " soles");
                    }
                    else if (dias > 5 && dias <= 10)
                    {
                        desayuno = (7 * dias);
                        total = 85 * dias;
                        final = total + desayuno;
                        Console.WriteLine("El pago que debe realizar es de " + final + " soles");
                    }
                    else if (dias > 10)
                    {
                        desayuno = (7 * dias);
                        total = 70 * dias;
                        final = total * desayuno;
                        Console.WriteLine("El pago que debe realizar es de " + final + " soles");
                    }
                    break;
                case "B":
                    Console.WriteLine("Cuantos días desea hospedarse");
                    dias = int.Parse(Console.ReadLine());
                    if (dias <= 5)
                    {
                        desayuno = (7 * dias);
                        total = 300 * dias;
                        final = total + desayuno;
                        Console.WriteLine("El pago que debe realizar es de " + final + " soles");
                    }
                    else if (dias > 5 && dias <= 10)
                    {
                        desayuno = (7 * dias);
                        total = 270 * dias;
                        final = total + desayuno;
                        Console.WriteLine("El pago que debe realizar es de " + final + " soles");
                    }
                    else if (dias > 10)
                    {
                        desayuno = (7 * dias);
                        total = 250 * dias;
                        final = total * desayuno;
                        Console.WriteLine("El pago que debe realizar es de " + final + " soles");
                    }
                    break;

            }
            Console.ReadKey();
        }
    }
}
