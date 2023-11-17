using System;

public class BubbleSort
{
    public static void Sort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    public static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(0, 100);
        }
        return array;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Generate a random array of integers
        int[] array = BubbleSort.GenerateRandomArray(10);

        // Sort the array in descending order
        BubbleSort.Sort(array);

        // Print the sorted array
        foreach (int element in array)
        {
            Console.WriteLine(element);
        }
    }
}
