using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Вас приветствует калькулятор");
                Console.Write("Введите число. X=");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите число. Y=");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите код операции: \n    1 сложение\n    2 вычетание\n    3 произведение\n    4 частное ");
                Console.Write("Ваш выбор: ");
                long n = Convert.ToInt64(Console.ReadLine());

                if (1 <= n && n <= 4) 
                { 
                Console.Write("Результат: ");
                
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
                            
                    }
                }
                  else
                    Console.WriteLine("Нет операции с указанным доступом");
                
            }

            catch (Exception ex)
            {
                Console.Write("Ошибка! ");
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();

        }
    }
}
