using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static int rangeFibo(int begin, int end) //выводит числа фибо из заданного диапазона
        {
            if (begin==0) { Console.Write("{0} ", 0); }
            int j = 1;
            for (int i = 1; i <= end; i += j)
            {
                if (i >= begin)
                {

                    Console.Write("{0} ", i);
                }
                j = i - j;

            }
            Console.ReadKey();
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Для вывода чисел по диапазону введите '0' для вывода по длине '1'");
            int choise = int.Parse(Console.ReadLine());


            if (choise == 0)
            { 
                Console.Write("Введите начало диапазона : ");
                int begin = int.Parse(Console.ReadLine());


                Console.Write("Введите конец диапазона  : ");
                int end = int.Parse(Console.ReadLine());

                rangeFibo(begin, end);

            }
            if (choise == 1)
            {
                Console.Write("Введите длину чисел фибо : ");

                int len = int.Parse(Console.ReadLine());
                int begin =(int)Math.Pow(10, (len - 1));
                if (begin == 1) { begin--; }
                int end =(int)Math.Pow(10, len);

                rangeFibo(begin,end);
            }
            
        }
    }
}
