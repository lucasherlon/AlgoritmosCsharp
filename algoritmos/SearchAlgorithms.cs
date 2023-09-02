﻿
namespace algoritmos;

public class SearchAlgorithms
{
    public static void LinearSearch(int[] array, int number)
    {
        foreach (int item in array)
        {
            if (item == number)
            {
                Console.WriteLine($"Number {item} found");
                return;
            }
        }
    }

    public static void BinarySearch(int[] array, int number)
    {
        int left = 0;
        int right = array.Length - 1;
        int middle = (left + right) / 2;

        while (left <= right)
        {
            if (array[middle] == number)
            {
                Console.WriteLine($"Number {number} found");

            }
            else if (array[middle] < number)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }

            middle = (left + right) / 2;
        }

        Console.WriteLine($"Number {number} not found");
    }

    public static int twoCrystalBalls(bool[] points)
    {
        int stepLength = (int) Math.Sqrt(points.Length);

    }
}
