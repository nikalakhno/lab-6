using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void DoBlock_1()
        {
            Console.WriteLine("Введіть кількість цілих чисел");
            int num = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 1; i <= num; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a < min)
                    min = a;
                if (a > max)
                    max = a;
            }
            Console.WriteLine(max - min);
        }

        static void DoBlock_2()
        {

            Console.WriteLine("Введіть послідовність цілих чисел, яка закінчується нулем: ");
            int num = int.Parse(Console.ReadLine());
            int index = 1, sum = 0;
            while (num != 0)
            {
                if (index % 2 == 0) //  умова парності числа
                    sum = sum + num;
                num = int.Parse(Console.ReadLine());
                index++;
            }
            Console.WriteLine(sum);
        }

        static void DoBlock_3()
        {
            int sum = 0;
            Console.Write("Введіть кількість елементів: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                sum += 2 * i - 1; //запис не парного числа 
            }
            Console.WriteLine("Результат: {0}", sum);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Для виконання блоку 1 (варіант 11) введіть 1");
                Console.WriteLine("Для виконання блоку 2 (варіант 20) введіть 2");
                Console.WriteLine("Для виконання блоку 3 (варіант 36) введіть 3");
                Console.WriteLine("Для виходу з програми введіть 0");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Виконую блок 1");
                        DoBlock_1();
                        break;
                    case 2:
                        Console.WriteLine("Виконую блок 2");
                        DoBlock_2();
                        break;
                    case 3:
                        Console.WriteLine("Виконую блок 3");
                        DoBlock_3();
                        break;
                    case 0:
                        Console.WriteLine("Зараз завершимо, тільки натисніть будь ласка ще раз Enter");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Команда ``{0}'' не розпізнана. Зробіь, будь ласка, вибір із 1, 2, 3, 0.", choice);
                        break;
                }
            } while (choice != 0);
        }
    }
}
