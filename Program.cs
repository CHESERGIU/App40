using System;

namespace App40
{
    class Program
    {
        static void Main(string[] args)
        {            
            int n = Int32.Parse(Console.ReadLine());
            
            int c = n;
            while (c != n - 1)
            {
                int[] r = { 10, 5, 3, 2, 1 };
                int p1 = n / r[0];
                int p2 = (n - p1 * r[0]) / r[1];
                int p3 = ((n - p1 * r[0]) - p2 * r[1]) / r[2];
                int p4 = ((n - p1 * r[0]) - p2 * r[1] - p3 * r[2]) / r[3];
                int p5 = ((n - p1 * r[0]) - p2 * r[1] - p3 * r[2] - p4 * r[3]);
                int[] n1 = { p1, p2, p3, p4, p5 };
                int s = p1 + p2 + p3 + p4 + p5;
                Console.WriteLine(s + " pachete");
                for (int i = 0; i <= 4; i++)
                    if (n1[i] != 0)
                        Console.WriteLine(n1[i] + " x " + r[i] + " buc");
                c--;
            }
            
        }
    }
}
