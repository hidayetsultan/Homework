using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine("arr:");
        PrintArray(arr);

        int numbers = 5;

        ResizeArray(ref arr, numbers);

        Console.WriteLine($"\n Yeniden olculmus ({numbers} ):");
        PrintArray(arr);
    }

    static void ResizeArray(ref int[] arr, int numbers)
    {
        if (numbers < 0)
        {
            throw new ArgumentException("Menfi olmasin.");
        }

        int[] newArr = new int[numbers];
        Array.Copy(arr, newArr, Math.Min(arr.Length, numbers));
        arr = newArr;
    }

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
    }
}
