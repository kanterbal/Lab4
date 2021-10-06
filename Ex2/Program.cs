using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите последовательность чисел");
            int negNumber = 0, posNumber = 0, number = 0;
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number > 0)
                {
                    posNumber++;
                }
                else if (number < 0)

                {
                    negNumber++;
                }
            }
            while (number != 0);
            if (negNumber > posNumber)
            {
                Console.WriteLine("Отрицательных больше");
            }
            else if (posNumber > negNumber)
            {
                Console.WriteLine("Положительных больше");
            }
            else
            {
                Console.WriteLine("Отрицательных и положительных поровну");
            }
            Console.ReadKey();
        }
    }
}
