﻿namespace algoritmos;

internal class Sorting
{
    public static void BubbleSort(int[] array)
    {
        int n = array.Length;
        int k = n;
        int temp = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j < k; j++)
            {
                if (array[j - 1] > array[j])
                { 
                    temp = array[j - 1];
                    array[j - 1] = array[j];
                    array[j] = temp;
                }
            }
            k--;
        }
    }

}
