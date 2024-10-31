//Реализовать пузырьковую сортировку массива. Делается n (размер массива) проходов,
//на каждом из которых последовательно просматриваются пары соседних элементов,
//и если их порядок неправилен, они меняются местами.

using System;

class Program
{
    static void Main(string[] args)
    {
       
        int[] array = { 37, 23, 45, 11, 29, 7, 68, 25,3 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

      
        BubbleSort(array);

        Console.WriteLine("Отсортированный массив:");
        PrintArray(array);
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;

    
        for (int i = 0; i < n; i++)
        {
        
            for (int j = 0; j < n - i - 1; j++)
            {
                
                if (arr[j] > arr[j + 1])
                {
                    
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void PrintArray(int[] arr)
    {
    
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
