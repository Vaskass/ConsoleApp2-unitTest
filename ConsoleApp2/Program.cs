using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Введите 3 значения температуры в цельсиях через enter");
            temp temp = new temp();
            try
            {
                temp.t1 = double.Parse(Console.ReadLine());
                temp.t2 = double.Parse(Console.ReadLine());
                temp.t3 = double.Parse(Console.ReadLine());

                if (temp.isTempIce())
                {
                    Console.WriteLine("Среди них есть температура таяния льда");
                }
                else
                {
                    Console.WriteLine("Среди них нет температуры таяния льда");
                }
                goto start;
            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели неверное значение");
                goto start;
            }

        }
    }
}
