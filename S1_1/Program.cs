using System;

namespace S1_1
{
    class Program
    {
     
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 2;
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(i + " " + b);
                
                b += 2;
            }
        }
    }
}
