using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtzkit_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть кількість цілих чисел");
            int num = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 1; i <= num; i = i + 1)
            {
                int a = int.Parse(Console.ReadLine());
                if (a < min)
                    min = a;
                if (a > max)
                    max = a;
            }
            Console.WriteLine(max - min);

        }
    }
}
