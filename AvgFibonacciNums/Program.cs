using System;

namespace fibo
{

    class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int n1 = 0;
            int n2 = 1;
            int nt = 0;
            float avgTotal = 0F;

            for (int i = 0; i < num1; i++)
            {
                nt = n1 + n2;
                n1 = n2;
                n2 = nt;
                avgTotal += (n1 + n2);
                Console.WriteLine($"{n1} , {n2}"); 
            }
            Console.WriteLine("Toplam = {0}", avgTotal);
            Console.WriteLine($"Ortalama = {avgTotal/num1}");
            Console.ReadLine();
        }
    }
}