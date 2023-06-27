using System;
using System.Linq;

namespace ArrayMinMaxCount
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 3.5, 2.7, 4.2, 1.8, 5.6, 2.1, 3.9, 2.2, 4.8, 3.3, 1.5, 6.1 };

            double min = array.Min();
            double max = array.Max();

            int count = array.SkipWhile(x => x != min).Skip(1).TakeWhile(x => x != max).Count();

            Console.WriteLine($"Количество чисел между минимальным ({min}) и максимальным ({max}) элементами: {count}");
        }
    }
}
