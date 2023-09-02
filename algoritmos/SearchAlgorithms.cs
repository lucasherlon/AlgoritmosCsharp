
namespace algoritmos;

internal class SearchAlgorithms
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
                return;

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
        int stepLength = (int) Math.Floor(Math.Sqrt(points.Length));

        int i = stepLength;
        for (; i < points.Length; i += stepLength)
        {
            if (points[i])
            {
                break;
            }
        }

        i -= stepLength;
        for (int j = 0; j < stepLength && i < points.Length; ++j, ++i)
        {
            if (points[i])
            {
                return i;
            }
           
        }
        return -1;
    }
}
