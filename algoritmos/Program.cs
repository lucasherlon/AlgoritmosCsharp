﻿using algoritmos;

class Algoritmos
{
    static void Main(string[] args)
    {   
        // Testing linear search
        int[] array = { 12, 34, 22, 89, 43, 55, 92, 8, 31, 19, 23, 76, 88, 41 };
        Search.LinearSearch(array, 55);

        // Testing binary search
        int[] array2 = { 8, 12, 19, 22, 23, 31, 34, 41, 43, 55, 76, 88, 89, 92 };
        Search.BinarySearch(array2, 55);

        // Testing two crystal balls
        bool[] points = { false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true };
        int result = Search.TwoCrystalBalls(points);
        Console.WriteLine($"The crystall ball strats to break in the position {result}");
        
        // Testing bubble sort
        int[] array3 = { 12, 80, 34, 22, 89, 43, 55, 92, 57, 8, 31, 19, 14, 23, 31, 76, 88, 41 };
        Sorting.BubbleSort(array3);
        foreach (int item in array3)
        {
            Console.Write($"{item} ");
        }
    }
}