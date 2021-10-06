using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число > 0: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (number > 0)
            {
                for (int i = 1; i < number+1; i++)
                {
                    sum += 2 * i - 1;
                    Console.Write("{0} ", sum);
                }
            }
            else
            {
                Console.WriteLine("Ошибка!!!");
            }
            Console.ReadKey();
        }
    }
}
