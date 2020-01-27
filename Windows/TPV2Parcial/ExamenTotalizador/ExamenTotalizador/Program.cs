using System;

namespace ExamenTotalizador
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {
                6, 4, 1
            };
            int t;
            int n = 0;
            for (int j = 0; j <= a.Length - 2; j++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                        n++;
                    }
                }
            }
            Console.WriteLine("Orden nuevo:");
            Console.Write("[");
            foreach (int p in a)
            {
                Console.Write(p + ", ");
            }
            Console.Write("]");
            Console.Write("\nPrimer elemento: " + a[0]);
            Console.Write("\nUltimo elemento: " + a[2]);
            Console.Write("\nLas permutas son: " + n);
        } 

    }
}