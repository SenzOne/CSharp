// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

System.Console.Write("Enter the number of array elements: ");
int CountElements = Convert.ToInt32(Console.ReadLine());

long MainMethod(int LenInputArr)
{
    int[] arr = CreatedArray(LenInputArr);
    arr = FillArray(arr);
    return GetSumOfOddPositions(arr);
}


// method for creating an array of length count
int[] CreatedArray(int count)
{
    int[] arr = new int[count];
    System.Console.WriteLine($"\nAn array of {count} elements has been created\n");
    return arr;
}


// method for filling an array with random numbers
int[] FillArray(int[] SecondCucleArr)
{
    Console.Write($"Added a number: ");
    for (int i = 0; i < SecondCucleArr.Length; i++)
    {   
        int NewNumber = new Random().Next(-10, 10);
        SecondCucleArr[i] = NewNumber;
        Console.Write($" {NewNumber}");
    }
    return SecondCucleArr;
}


// method  for finding the sum of numbers at odd positions
long GetSumOfOddPositions(int[] ResultArr)
{
    long sum = 0;
    for (int i = 0; i < ResultArr.Length; i+= 2)
    {
        sum += ResultArr[i];
    }
    return sum;
}


Console.WriteLine($"\n\nSum of odd positions {MainMethod(CountElements)}\n");
