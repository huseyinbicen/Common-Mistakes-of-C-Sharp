using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonMistakes1
{
    class Program
    {
        static void Main(string[] args)
        {
            float num = 1f;
            for (int i = 0; i < 10; i++)
            {
                num -= 0.1f;
                Console.WriteLine(num);

                if (num == 0) //Wrong!! true:  num <= 0
                {
                    Console.WriteLine("The programm stopped.");
                }
            }

            Console.ReadKey();
        }
    }
}
