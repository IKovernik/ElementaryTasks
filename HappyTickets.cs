using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sum = new int[28];

            for (int part = 0;part <=999; part++)// берем трехзначное число (половина номера билета)
            {
                int d1 = part / 100;
                int d2 = (part/10) % 10;
                int d3 = part % 10;//разбиваем на цифры

                int partSum = d1 + d2 + d3;//находим сумму цифер

                
                sum[partSum]++;//заполняем массив соотвестственно количеству вхождений той или иной суммы
            }

            int count = 1; //заводим переменную для подсчета комбинаций
            for (int k=0;k<27; k++)
            {
                count += sum[k]*sum[k];
              // Console.WriteLine(sum[k]);
                Console.WriteLine("кол-во классических 'счастливых' билетов "+count);
            }


        }
    }
}
