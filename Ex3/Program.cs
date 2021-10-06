using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительные числа A, B, C");
            ushort a = Convert.ToUInt16(Console.ReadLine());
            ushort b = Convert.ToUInt16(Console.ReadLine());
            ushort c = Convert.ToUInt16(Console.ReadLine());
            ushort x = c, y = c, s = 0;
            while (x <= a)
            {
                s++;
                x += c;
            }
            x = s;
            s = 0;
            while (y <= b)
            {
                s += x;
                y += c;
            }
            Console.WriteLine("Возможное кол-во квадратов со стороной С (без наложения) = {0}", s);
            Console.ReadKey();
        }
    }
}
