using algoritmos;
class Algoritmos
{
    static void Main(string[] args)
    {   
        //Testing linear search
        int[] array = { 12, 34, 22, 89, 43, 55, 92, 8, 31, 19, 23, 76, 88, 41 };
        SearchAlgorithms.LinearSearch(array, 55);

        //Testing binary search
        int[] array2 = { 8, 12, 19, 22, 23, 31, 34, 41, 43, 55, 76, 88, 89, 92 };
        SearchAlgorithms.BinarySearch(array2, 55);
    }

    

    

    
}