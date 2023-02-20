// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


int Prompt(string massege)
{
    System.Console.Write(massege);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int[,] CreaateArray(int m = 5, int n = 9)
{
    int[,] array = new int[m, n];
    return array;
}


void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j],4}  ");
        }
        System.Console.WriteLine();
    }
}


int[,] FillArrayRandom(int[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = new Random().Next(-9, 10);
        }
    }
    return coll;
}


void ReplaceRowsFirstVsLast(int[,] coll)
{
    for (int i = 0; i < coll.GetLength(1); i++)
    {
        // System.Console.WriteLine(coll[i,0]);
        for (int j = 0; j < coll.GetLength(0); j++)
        {
            System.Console.Write($"{coll[j,i],4}  ");
        }
        System.Console.WriteLine();
    }
}

void Main()
{
    int[,] arr = CreaateArray();
    arr = FillArrayRandom(arr);
    PrintArr(arr);
    System.Console.WriteLine();
    ReplaceRowsFirstVsLast(arr);
}

Main();