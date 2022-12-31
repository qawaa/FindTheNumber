using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1;
            Random random;

            Console.WriteLine("Игра 'Найди число'\nУ вас 10 попыток!\nЗадайте интервал!");
            while (true)
            {
                Console.Write("Введите 1ое число: ");
                int x = int.Parse(Console.ReadLine()!);
                Console.Write("Введите 2ое число: ");
                int y = int.Parse(Console.ReadLine()!);


                random = new Random();
                var Numeric = random.Next(x,y);
                class1 = new Class1(Numeric);
                int k = random.Next(x, y);
                

                Console.WriteLine("Угадайте число в интервале от {0} до {1}\n", x, y);

                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Ваше число: ");
                    if (int.TryParse(Console.ReadLine(), out int input))
                    {
                        class1.NumberSearch(input);
                        Console.WriteLine(class1.ReturnResult());
                        if (class1.GetSuccess())
                        {
                            Console.WriteLine("Правильно!");
                            break;
                        }


                    }
                }
            }
        }
    }
}

        