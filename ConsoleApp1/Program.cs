using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int size = int.Parse(Console.ReadLine());
            int g, g1;
            if (size % 2 == 0)
            {
                g = size / 2;
                g1 = size / 2;
            }
            else
            {
                g = size / 2+1;
                g1 = size / 2;
            }
            double[] arr = new double[size];
            double[] arr1 = new double[g];
            double[] arr2 = new double[g1];
            string buf;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Введите элемент массива {0}", i );
                buf = Console.ReadLine();
                arr[i] = Convert.ToDouble(buf);
            }
            double d = 1;
            foreach (double x in arr)
            {
                if (x > 0) d = d * x;
            }
            double min = arr[0];
            foreach (double x in arr)
            {
                if (x < min) min = x;
            }
            double sym = 0;
            foreach (double x in arr)
            {
                if (x > min) sym = sym + x;
                else break;
            }
            int j = 0;
            for (int i = 0; i < size; i++)
            {
                if (i % 2 == 0)
                {
                    arr1[j] = arr[i];
                    j++;
                }
            }
            Array.Sort(arr1);
            j = 0;
            for (int i = 0; i < size; i++)
            {
                if (i % 2 != 0)
                {
                    arr2[j] = arr[i];
                    j++;
                }
            }
            Array.Sort(arr2);
            PrintArray("отсортированные четные элементы ", arr1);
            PrintArray("отсортированные нечетные элементы", arr2);
            j = 0;
            if (size % 2 == 0)
            {
                for (int i = 0; i < size; i++)
                {
                    arr[i] = arr1[j];
                    i++;
                    arr[i] = arr2[j];
                    j++;
                }
            }
            else
            {
                for (int i = 0; i < size-1; i++)
                {
                    arr[i] = arr1[j];
                    i++;
                    arr[i] = arr2[j];
                    j++;
                }
                arr[size - 1] = arr1[j];
            }
            PrintArray("отсортированный массив", arr);
            Console.WriteLine("Произведение положительных ненулевых элементов массива =" + d);
            Console.WriteLine("Cумму элементов массива, расположенных до минимального элемента ({0}) = {1}", min, sym);
            Console.ReadKey();
            Console.ReadKey();
        }
        public static void PrintArray(string mes, double[] a)

        {

            Console.WriteLine(mes);

            for (int i = 0; i < a.Length; i++)

                Console.Write("\t" + a[i]);

            Console.WriteLine();

        }
    }
}
