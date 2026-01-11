using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 3, 8, 4, 2 };

        Console.WriteLine("Simple Array:");
        ShowArray(numbers);

        BubbleSort(numbers);

        Console.WriteLine("\nSorted Array:");
        ShowArray(numbers);
    }

    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        bool isExchange=false;

        for (int cont = 0; cont < n - 1; cont++)
        {
            for (int cont2 = 0; cont2 < n - cont - 1; cont2++)
            {
                if (array[cont2] > array[cont2 + 1])
                {
                    (array[cont2],array[cont2 + 1])=(array[cont2 + 1],array[cont2]);
                    isExchange = true;
                }
            }
        }
    }

    static void ShowArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}