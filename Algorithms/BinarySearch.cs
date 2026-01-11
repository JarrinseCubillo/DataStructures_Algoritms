using System;

class Program
{
    public static void Main()
    {
        int[] numbers = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
        int searchValue = 23;

        int result = BinarySearch(numbers, searchValue);

        if (result != -1)
            Console.WriteLine($"Item Found in position: {result}");
        else
            Console.WriteLine("Item Not Found");
    }
	
	
	public static int BinarySearch(int[] array, int searchedValue)
    {
        int first = 0;
        int last = array.Length - 1;

        while (first <= last)
        {
            int middle = (first + last) / 2;

            if (array[middle] == searchedValue)
                return middle;

            if (array[middle] < searchedValue)
                first = middle + 1;
            else
                last = middle - 1;
        }

        return -1; 
    }

    
}