using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Divisores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nro, Cdiv, divisor, pares, impares;
            double porcentajePar, porcentajeImpar;

            Console.WriteLine("Divisores de un numero");
            Console.WriteLine("***********************");
            Console.Write("Ingrese número: ");
            nro = int.Parse(Console.ReadLine());

            Cdiv = 0;

            for (divisor = 1; divisor <= nro; divisor++)
            {
                if ((nro % divisor) == 0)
                {
                    Cdiv++;
                    Console.WriteLine("Divisor : " + divisor);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Cantidad de Divisores : " + Cdiv);

            Console.WriteLine("");
            Console.WriteLine("Los numeros pares: ");
            for (pares = 1; pares <= nro; pares++)
            {
                if (pares % 2 == 0)
                {
                    Console.Write(pares + ", ");
                    Console.Write("");
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("Los numeros impares: ");
            for (impares = 0; impares < nro; impares++)
            {
                if (impares % 2 == 0)
                {
                    Console.Write(impares + 1 + ", ");
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Porcentaje de los números pares: ");
            for (pares = 1; pares <= nro; pares++)
            {
                if (pares % 2 == 0)
                {
                    porcentajePar = ((double)pares / nro) * 100;
                    Console.WriteLine(pares+ " = " + porcentajePar + " %");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Porcentaje de los números impares: ");
            for (impares = 0; impares < nro; impares++)
            {
                if (impares % 2 == 0)
                {
                    porcentajeImpar = ((double)(impares+1)  / nro) * 100;
                    Console.WriteLine(impares + 1 + " = " + porcentajeImpar + " %");
                }
            }
            Console.ReadKey();
        }
    }
}