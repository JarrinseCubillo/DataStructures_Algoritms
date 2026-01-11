using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 3, 19, 8, 4, 2 };
        
        Console.WriteLine("Array No Quick Sort:");
        ShowArray(numbers);

        QuickSort(numbers, 0, numbers.Length - 1);
        
        Console.WriteLine("\n\nQuick Sort:");
        ShowArray(numbers);
    }
    
    static void QuickSort(int[] array, int first, int last)
    {
        if (first < last)
        {
            int pivotIndex = SliceArray(array, first, last);
            QuickSort(array, first, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, last);
        }
    }

    static int SliceArray(int[] array, int first, int last)
    {
        int pivot = array[last];
        int index = first - 1;

        for (int cont = first; cont < last; cont++)
        {
            if (array[cont] <= pivot)
            {
                index++;
                (array[index], array[cont]) = (array[cont], array[index]);    
            }
            
        }
        (array[index+1],array[last])=(array[last],array[index+1]);
        return index + 1;
    }

    public static void ShowArray(int[] array)
    {
        foreach (int item in array)
            Console.Write(item + " ");
    }
    
}