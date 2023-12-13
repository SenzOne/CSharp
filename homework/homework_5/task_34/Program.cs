// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

System.Console.Write("Enter the number of array elements: ");
int CountElements = Convert.ToInt32(Console.ReadLine());

// Main method
int MainMethod(int LenInputArr)
{
    int[] arr = CreatedArray(LenInputArr);
    arr = FillArray(arr);
    System.Console.WriteLine("");
    return GetEvenNumbers(arr);
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
        int NewNumber = new Random().Next(100, 1000);
        SecondCucleArr[i] = NewNumber;
        Console.Write($" {NewNumber}");
    }
    return SecondCucleArr;
}


// Method for finding black numbers in an array
int GetEvenNumbers(int[] ResultArr)
{
    Console.Write($"Found number: ");
    int count = 0;
    for (int i = 0; i < ResultArr.Length; i++)
    {
        if(ResultArr[i] % 2 == 0)
        {
            count += 1;
            Console.Write($" {ResultArr[i]}");
        }
    }
    return count;
}

System.Console.WriteLine($"\nThe number of even numbers is: {MainMethod(CountElements)}\n");
