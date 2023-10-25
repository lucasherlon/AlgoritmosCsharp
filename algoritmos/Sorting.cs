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
            int pivot = partition(array, left, right);

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

    private static int partition(int[] array, int left, int right)
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

    public static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            MergeSort(array, left, middle);
            MergeSort(array, middle + 1, right);

            merge(array, left, middle, right);
        }
    }

    private static void merge(int[] array, int left, int middle, int right)
    {
        int[] temp = new int[right - left + 1];
        int i, j, k;
        i = left;
        j = middle + 1;
        k = 0;

        while (i <= middle && j <= right)
        {
            if (array[i] < array[j])
            {
                temp[k] = array[i];
                k++;
                i++;
            }
            else
            {
                temp[k] = array[j];
                k++;
                j++;
            }
        }

        while (i <= middle)
        {
            temp[k] = array[i];
            k++;
            i++;
        }

        while (j <= right)
        {
            temp[k] = array[j];
            k++;
            j++;
        }

        for (i = left; i <= right; i++)
        {
            array[i] = temp[i - left];
        }
    }

    public static void InsertionSort(int[] array)
    {
        int n = array.Length;

        for (int i = 1; i < n; ++i)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j = j - 1;
            }

            array[j + 1] = key;
        }
    }


}
