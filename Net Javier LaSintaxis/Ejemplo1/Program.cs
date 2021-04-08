using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            float b;
            char c = 'z';
            bool f;

            a = 10;
            a = (10 + 15) / 2 * 3 - 7 % 2;
            a += 10;
            a++;
            Console.WriteLine("Ingrese un numero:");
            a = int.Parse(Console.ReadLine());

            a += 10;

            Console.WriteLine("El valor es... " + a);
            Console.ReadLine();

            if (a > 10)
            {
                Console.WriteLine("Es mayor a 10...");
            }
            else if ((a==5 && c=='a') || c=='z')
            {
                Console.WriteLine("El valor es igual a 5...");
            }
            else
            {
                Console.WriteLine("El valor es menor a 10 pero no es 5...");
            }

            if (a == 10)
                Console.WriteLine("Es 10");
            else
                Console.WriteLine("No es 10");

            switch (c)
            {
                case 'a':
                    Console.WriteLine("La variable tiene a");
                    break;
                case 'b':
                    Console.WriteLine("La variable tiene b...");
                    break;
                default:
                    Console.WriteLine("lalalala");
                    break;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hola Mundo");
            }

            //while (a!=0)
            //{

            //}

            //foreach (var item in collection)
            //{

            //}

            holamundo();
            int resultado = sumar(3, 6);
            int r=10;
            restar(ref r, 9);
            Console.WriteLine("El resultado de la funcion Restar es:");
            Console.WriteLine(r);
            Console.ReadLine();

        }//Aca termina el main
        static void holamundo()
        {
            Console.WriteLine("Hola mundo");
        }

        static int sumar(int a, int b)
        {
            return a + b;
        }

        static void restar(ref int j, int b)
        {
            j = j - b;
        }
    }
}
