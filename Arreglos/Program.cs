using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Tam = 10;
            int sumapar = 0, sumaimpar = 0;
            int[] numeros = new int[Tam];
            Console.WriteLine("digite los datos del arreglo");
            Console.WriteLine();
            for (int i = 0; i < Tam; i++)
            {//lectura
                Console.Write("ingresa numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
                if (numeros[i] % 2 == 0) 
                {
                    sumapar += numeros[i]; 
                }
                else 
                { 
                    sumaimpar += numeros[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Datos del arreglo:");
            Console.WriteLine();
            for (int i = 0; i < Tam; i++)
            {//Muestra en pantalla 
                Console.Write(numeros[i] + ",");
            }
            Console.WriteLine("La suma de los numeros pares es: " + sumapar);
            Console.WriteLine("La suma de los numeros impares es: " + sumaimpar );
            Console.ReadKey();
        } 
    }
}
