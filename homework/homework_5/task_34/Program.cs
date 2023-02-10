// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

System.Console.Write("Введи количество Элементов массива: ");
int CountElements = Convert.ToInt32(Console.ReadLine());

int MainMethod(int LenInputArr)
{
    int[] arr = CreatedArray(LenInputArr);
    arr = FillArray(arr);
    System.Console.WriteLine("");
    return EvenNumbers(arr);
}


int[] CreatedArray(int count)
{
    int[] arr = new int[count];
    System.Console.WriteLine($"\nAn array of {count} elements has been created\n");
    return arr;
}


int[] FillArray(int[] SecondCucleArr)
{
    for (int i = 0; i < SecondCucleArr.Length; i++)
    {   
        int NewNumber = new Random().Next(100, 1000);
        SecondCucleArr[i] = NewNumber;
        System.Console.WriteLine($"added a number {NewNumber}");
    }
    return SecondCucleArr;
}


int EvenNumbers(int[] ResultArr)
{
    int count = 0;
    for (int i = 0; i < ResultArr.Length; i++)
    {
        if(ResultArr[i] % 2 == 0)
        {
            count += 1;
            System.Console.WriteLine($"Found number {ResultArr[i]}");
        }
    }
    return count;
}

System.Console.WriteLine($"\nThe number of even numbers is {MainMethod(CountElements)}\n");
