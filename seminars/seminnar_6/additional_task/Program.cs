// Создать двумерный массив найти min на каждой строке 
// находим максимальный из минимальных 


int Prompt(string massege)
{
    Console.Write(massege);
    string readInput = Console.ReadLine();
    int result = Convert.ToInt32(readInput);
    return result;
}


int[,] CreaateArray(int m, int n)
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
            Console.Write($"{array[i, j], 4}  ");
        }
        Console.WriteLine();
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



int[] FindMin(int[,] coll)
{
    int[] minArr = new int[coll.GetLength(0)];

    for (int i = 0; i < coll.GetLength(0); i++)
    {
        int minOfString = coll[i,0];
        for (int j = 0; j < coll.GetLength(1); j ++)
        {
            if(coll[i, j] < minOfString) minOfString = coll[i, j]; 
        }
        minArr[i] = minOfString;
    }
    return minArr;
}


int GetMax(int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
    }
    return max;
}


int[,] arr = CreaateArray(Prompt("Введи кол-во строк: "), Prompt("Введи кол-во столбцов: "));
arr = FillArrayRandom(arr);
PrintArr(arr);
int[] minArr = FindMin(arr);
Console.WriteLine();
Console.WriteLine($"массив из минимальных чисел -> {string.Join(", ", minArr)}\n");
Console.WriteLine($"Максимальное из минимальных -> {GetMax(minArr)}");
