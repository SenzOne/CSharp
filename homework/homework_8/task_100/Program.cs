// Задача 62. Напишите программу, которая 
// заполнит спирально через 1 строку массив n на n.

// немного доработанная и более красивая вариация 
// задачи 62


int Prompt(string massege)
{
    System.Console.Write(massege);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

string[,] CreaateArray(int m = 10, int n = 10)
{
    string[,] array = new string[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = " ";
        }
    }
    return array;
}


void PrintArr(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j], 1}  ");
        }
        System.Console.WriteLine();
    }
}

string[,] FillArray(string[,] arr, string sim = " ")
{
    int size = arr.GetLength(1);
    string simbol = sim;

    for (int delta = 0; delta < size - 2; delta += 2)
    {
        for (int i = 0 + delta; i < size - 1 - delta; i++)
        {
            arr[0 + delta, i] = simbol;
        }

    for (int i = 0 + delta; i < size - 1 - delta; i++)
        {
            arr[i, (size - 1) - 1 - delta] = simbol;
        }

    for (int i = size - 1 - 1 - delta; i >= 0 + 1 + delta; i--)
        {
            arr[(size - 1 - 1) - delta, i] = simbol;
        }
    for (int i = size - 1 - 1 - delta; i >= 1 + 1 + delta; i--)
        {
            arr[i, 0 + 1 + delta] = simbol;
        }
    }
    return arr;
}


void Main()
{   
    int n = Prompt("введи размер спирали: ");
    string[,] arr = CreaateArray(n, n);
    arr = FillArray(arr, "*");
    PrintArr(arr);
}

Main();

