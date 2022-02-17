using System;

namespace MethodAray 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВВедите количествоэлементов в масиве: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("найти разность между максимальными и минимальными элементами массива + 2.Поменять местами макс и мин элемент массива. + 3.Отсортировать массив");
           
            meArray(arr);
            maxmin(arr);
            swap(arr);
            for (int i = 0; i <  arr.Length; i++)
            {
                Console.WriteLine($"Array[{i}] = {arr[i]}");
            }
            Sortirovka(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Array[{i}] = {arr[i]}");
            }
        }
        static void meArray(int[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine($"Array[{i}] = ");
                s[i] = int.Parse(Console.ReadLine());
            }
        }
        static void maxmin(int[] a)
        {
            int max = a[0];
            int min = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (max < a[i]) max = a[i];
                if (min > a[i]) min = a[i];
            }
            Console.WriteLine($"разность между максимальными и минимальными элементами массива {max - min}");
        }
        static void swap(int[] array)
        {
            if (array.Length <= 1) return;

            int min = 0, max = 0;
            for (var i = 1; i < array.Length; i++)
                if (array[i] > array[max])
                    max = i;
                else if (array[i] < array[min])
                    min = i;

            var temp = array[min];
            array[min] = array[max];
            array[max] = temp;
        }
        static void  Sortirovka(int[] massiv)
        {
            for (int i = 0; i < massiv.Length; i++ )
            {
                for (int j = 0; j < massiv.Length - i - 1;j++ )
                {
                    if(massiv[j] > massiv[j + 1])
                    {
                        int temp = massiv[j];
                        massiv[j] = massiv[j + 1];
                        massiv[j + 1] = temp;
                    }
                }
            }
        }
    }
}

