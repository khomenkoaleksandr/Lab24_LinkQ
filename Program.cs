using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab24_LinkQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of array elements");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter {0} number", i + 1);
                int x = Convert.ToInt32(Console.ReadLine());
                array[i] = x;
            }

            SumMethod(array);
            UnicMethod(array);
            SeparateArrayToness(array);
        }

        public static void SumMethod(int[] array)
        {
            var sum = array.Select(p => (int)p).Sum();

            Console.WriteLine("Сумма чисел = {0}", sum);
            Console.ReadLine();
        }

        static void UnicMethod(int[] array)
        {
            var uniqueCollection = array.Select(p => (int)p).Distinct();

            foreach (int i in uniqueCollection)
            Console.WriteLine("Вот список уникальные элеметнов = {0}", i);
            Console.ReadLine();
        }

        static void SeparateArrayToness(int[] array)
        {

            var evenNumbers = array.Select(p => (int)p).Where(p => p % 2 == 0);
                

            foreach (int i in evenNumbers)

            Console.WriteLine("Парные значения = {0}", i);
            Console.ReadLine();
        }

    }
}
