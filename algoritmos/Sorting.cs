namespace algoritmos;

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

    public static void QuickSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(array, left, right);

            if (pivot > 1)
            {
                QuickSort(array, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                QuickSort(array, pivot + 1, right);
            }
        }
    }

    public static int Partition(int[] array, int left, int right)
    {
        int pivot = array[left];

        while (true)
        {
            while (array[left] < pivot)
            {
                left++;
            }

            while (array[right] > pivot)
            {
                right--;
            }

            if (left < right)
            {
                if (array[left] == array[right])
                {
                    return right;
                }

                int temp = array[left];
                array[left] = array[right];
                array[right] = temp;
            }
            else
            {
                return right;
            }
        }
    }   

}
