using System;

namespace calculos
{
    class program
    {
        static void Main(string[] args)
        {
            int num;
            double raiz;

            Console.WriteLine("Ingresa un numero entero mayor que 0 :");
            Console.WriteLine(" ");
            num = int.Parse(Console.ReadLine());

            raiz = Math.Sqrt(num);
            Console.WriteLine("La raiz cuadrada de el numero {0} es {1}", num, raiz );

            Console.WriteLine("\t");
            Console.WriteLine("Para ecuacion de tipo ax^2+bx+c=0 digita dos numeros mas 'B' y 'C' :");
            Console.WriteLine("Ingresa B :");
            double num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa C :");
            double num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            double discriminante = num2 * num2 - 4 * raiz * num3;

            if (discriminante > 0)
            {
                double raiz1 = (-num2 + Math.Sqrt(discriminante)) / (2 * raiz);
                double raiz2 = (-num2 - Math.Sqrt(discriminante)) / (2 * raiz);
                Console.WriteLine($"Las raices son : {double.Round(raiz1, 2)} y {double.Round(raiz2,2)}");
            }
            else if (discriminante == 0)
            {
                double raizUnica = -num2 / (2 * raiz);
                Console.WriteLine($"la Raiz unica es : {double.Round(raizUnica, 2)}");
            }
            else
            {
                Console.WriteLine("La ecuacion no tiene soluciones reales");
            }
        }
    }
}

