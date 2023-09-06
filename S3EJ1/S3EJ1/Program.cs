using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3EJ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruta;
            int dist, cajas;
            float pago; 
            Console.WriteLine("Ingrese el tipo de fruta que desea cargar");
            Console.WriteLine("A)Naranja");
            Console.WriteLine("B)Fresa");
            Console.WriteLine("C)Mango");
            fruta = Console.ReadLine();
            switch (fruta)
            {
                case "A":
                    Console.WriteLine("Ingrese la distancia a recorrer en kilometros");
                    dist = int.Parse(Console.ReadLine());
                    if (dist >= 30)
                    {
                        Console.WriteLine("Cuantas cajas contiene su carga?");
                        cajas = int.Parse(Console.ReadLine());
                        pago = (4.00f * cajas);
                        Console.WriteLine("El pago que debe hacer es de "+ pago + " soles");
                    }
                    else
                    {
                        Console.WriteLine("Cuantas cajas contiene su carga?");
                        cajas = int.Parse(Console.ReadLine());
                        pago = (2.00f * cajas);
                        Console.WriteLine("El pago que debe hacer es de " + pago + " soles");
                    }
                    break;
                case "B":
                    Console.WriteLine("Ingrese la distancia a recorrer en Kilometros");
                    dist = int.Parse(Console.ReadLine());
                    if (dist >= 30)
                    {
                        Console.WriteLine("Cuantas cajas contiene su carga?");
                        cajas = int.Parse(Console.ReadLine());
                        pago = (9.00f * cajas);
                        Console.WriteLine("El pago que debe hacer es de " + pago + " soles");
                    }
                    else
                    {
                        Console.WriteLine("Cuantas cajas contiene su carga?");
                        cajas = int.Parse(Console.ReadLine());
                        pago = (6.00f * cajas);
                        Console.WriteLine("El pago que debe hacer es de " + pago + " soles");
                    }
                    break; 
                case "C":
                    Console.WriteLine("Ingrese la distancia a recorrer en Kilometros");
                    dist = int.Parse(Console.ReadLine());
                    if (dist >= 30)
                    {
                        Console.WriteLine("Cuantas cajas contiene su carga?");
                        cajas = int.Parse(Console.ReadLine());
                        pago = (5.00f * cajas);
                        Console.WriteLine("El pago que debe hacer es de " + pago + " soles");
                    }
                    else
                    {
                        Console.WriteLine("Cuantas cajas contiene su carga?");
                        cajas = int.Parse(Console.ReadLine());
                        pago = (3.00f * cajas);
                        Console.WriteLine("El pago que debe hacer es de " + pago + " soles");
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
