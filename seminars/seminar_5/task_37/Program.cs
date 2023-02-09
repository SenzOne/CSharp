// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// Пока что не доделана!

System.Console.WriteLine("Введи количество элементов массива: ");
int Count_Numbers = Convert.ToInt32(Console.ReadLine());

int[] SumExremes(int num)
{
    int[] arr = CreateArr(num);
    Console.WriteLine(string.Join(", ", arr));
    arr = FillRandom(arr);
    Console.WriteLine(string.Join(", ", arr));
    int[] ResultArr = new int[3];
    for (int i = 0, j = arr.Length - 1 ; i < arr.Length; i++, j--)
    {
        for (int k = 0; k < ResultArr.Length; k++)
        {
            ResultArr;
        }
    }
    return ResultArr;
}

int[] CreateArr(int numbers)
{
    int[] arr = new int[numbers];
    return arr;
}
int[] FillRandom(int[] arry)
{
    for (int i = 0; i < arry.Length; i++)
    {
        arry[i] = new Random().Next(1, 100);
    }
    return arry;
}

Console.WriteLine(string.Join(", ", SumExremes(Count_Numbers)));
