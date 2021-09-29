using System;

namespace ficha_programação4
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.1415;
            double a, r;
            Console.WriteLine("Informe qual o valor do raio do círculo");
            r = Double.Parse(Console.ReadLine());
            a = pi * (Math.Pow(r, 2));
            Console.WriteLine("O valor da área do círculo é:{0}", a);
            Console.ReadLine();
        }
    }
}
