using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input length 'n'");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("input num 'm'");
            int m = int.Parse(Console.ReadLine());



            double start = Math.Sqrt(m);
            start = Math.Ceiling(start);//округляю корень квадратный в большую сторону

            int startint = (int)start;
            //Console.WriteLine(start);

            for (int i = startint; i < (startint+n); i++)
            {
                Console.Write(i +", ");
            }
        }
    }
}
