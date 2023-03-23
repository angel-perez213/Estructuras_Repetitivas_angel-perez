    using System;

namespace Estructuras_Repetitivas_angel_perez
{
        class Ejercicios
        {
            public void ImprimirNumerosPares()
            {
                int num;
                do
                {
                    Console.Write("Ingrese un número positivo (99 para salir): ");
                    num = int.Parse(Console.ReadLine());
                    if (num % 2 == 0)
                    {
                        Console.WriteLine(num);
                    }
                } while (num != 99);
            }

            public void ImprimirEstructura(int n)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }

            public void SumaDivisiblesEntre9()
            {
                int suma = 0;
                Console.WriteLine("Números divisibles entre 9 entre 100 y 200:");
                for (int i = 100; i <= 200; i++)
                {
                    if (i % 9 == 0)
                    {
                        Console.Write(i + " ");
                        suma += i;
                    }
                }
                Console.WriteLine("\nLa suma de los números es: " + suma);
            }

            public void TablaMultiplicar()
            {
                Console.Write("Ingrese un número del 1 al 10: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("Tabla de multiplicar del " + num + ":");
                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine(num + " x " + i + " = " + (num * i));
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Ejercicios ejercicios = new Ejercicios();

                Console.WriteLine("Ejercicio 1 - Imprimir números pares:");
                ejercicios.ImprimirNumerosPares();

                Console.WriteLine("Ejercicio 2 - Imprimir estructura:");
                Console.Write("Ingrese un número de filas: ");
                int n = int.Parse(Console.ReadLine());
                ejercicios.ImprimirEstructura(n);

                Console.WriteLine("Ejercicio 3 - Suma de números divisibles entre 9:");
                ejercicios.SumaDivisiblesEntre9();

                Console.WriteLine("Ejercicio 4 - Tabla de multiplicar:");
                ejercicios.TablaMultiplicar();

                Console.ReadKey();
            }
        }
}
