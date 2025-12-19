// вариант 3: поиск пересечения двух массивов

using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static List<int> FindIntersection(int[] arr1, int[] arr2)
    {
        List<int> intersection = new List<int>();
        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr2.Length; j++)
            {
                if (arr1[i] == arr2[j] && !intersection.Contains(arr1[i]))
                {
                    intersection.Add(arr1[i]);
                }
            }
        }
        return intersection;
    }
    static List<int> FindIntersectionOptimized(int[] arr1, int[] arr2)
    {
        HashSet<int> set1 = new HashSet<int>(arr1);
        HashSet<int> intersection = new HashSet<int>();

        foreach (int num in arr2)
        {
            if (set1.Contains(num))
            {
                intersection.Add(num);
            }
        }

        return new List<int>(intersection);
    }


    static void Main()
    {
        int N = 100000;
        int[] arr1 = new int[N];
        int[] arr2 = new int[N];

        for (int i = 0; i < N; i++)
        {
            arr1[i] = (i);
            arr2[i] = (i+N/3);
        }
        int[] arr3 = {1, 2, 3, 4, 5 };
        int[] arr4= {3, 4, 5, 6, 7 };

        int V = 100000;
        int[] arr6 = new int[V];
        int[] arr5 = new int[V];

        Stopwatch sw1 = Stopwatch.StartNew();
        List<int> intersection1 = FindIntersection(arr1, arr2);
        sw1.Stop();
        Console.WriteLine("Количество элементов: " + N);
        Console.WriteLine("Пересечение: " + string.Join(", ", "intersection1!"));
        Console.WriteLine("Время: " + sw1.ElapsedTicks + " тиков");
        Console.WriteLine("Старый алгоритм: " + sw1.ElapsedMilliseconds + " мс");

        Stopwatch sw2 = Stopwatch.StartNew();
        List<int> intersection2 = FindIntersectionOptimized(arr1, arr2);
        sw2.Stop();
        Console.WriteLine("Пересечение: " + string.Join(", ", "intersection2!"));
        Console.WriteLine("Время: " + sw2.ElapsedTicks + " тиков");
        Console.WriteLine("Новый алгоритм: " + sw2.ElapsedMilliseconds + " мс");
    }
}