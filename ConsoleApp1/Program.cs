using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите код операции: \n    1 сложение\n    2 вычетание\n    3 произведение\n    4 частное ");
            long n = Convert.ToInt64(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine(x + y);
                    break;
                case 2:
                    Console.WriteLine(x - y);
                    break;
                case 3:
                    Console.WriteLine(x * y);
                    break;
                case 4:
                    Console.WriteLine(x / y);
                    break;
                    Console.WriteLine("Ваш выбор: {0}", n);
            }
        }
    }
}
