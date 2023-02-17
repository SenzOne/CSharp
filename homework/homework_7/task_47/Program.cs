// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int Prompt(string massege)
{
    System.Console.Write(massege);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


double[,] CreaateArray(int m, int n)
{
    double[,] array = new double[m, n];
    return array;
}


void PrintArr(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j], 5}  ");
        }
        System.Console.WriteLine();
    }
}


double[,] FillArrayRandom(double[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = Math.Round(new Random().NextDouble() * 100, 2);
        }
    }
    return coll;
}


void Main()
{
    double[,] arr = CreaateArray(Prompt("Введи кол-во строк: "), Prompt("Введи кол-во столбцов: "));
    arr = FillArrayRandom(arr);
    Console.WriteLine();
    PrintArr(arr);
}

Main();


