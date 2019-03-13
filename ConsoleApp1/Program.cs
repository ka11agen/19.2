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
            int[] arr = new int[size];
            string buf;
            for (int i=0; i<size; i++)
            {
                Console.WriteLine("Введите arr[{0}]", i);
                buf = Console.ReadLine();
                arr[i] = Convert.ToInt32(buf);
            }
            int d=1;
            foreach(int x in arr)
            {
                if (x > 0) d = d * x;
            }
            int min = arr[0];
            foreach (int x in arr)
            {
                if (x < min) min=x;
            }
            int sym = 0;
            foreach (int x in arr)
            {
                if (x > min) sym=sym+x;
                else break;
            }
            Console.WriteLine("Произведение положительных ненулевых элементов массива =" + d);
            Console.WriteLine("Cумму элементов массива, расположенных до минимального элемента ({0}) = {1}" , min , sym);
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
