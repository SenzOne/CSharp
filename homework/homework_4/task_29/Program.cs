// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

System.Console.Write("Сколько элементов будет в массивве ");
int Num = Convert.ToInt32(Console.ReadLine());

int[] GetArray(int CountNumber)
{
    int[] arr = new int[CountNumber];
    
    System.Console.Write("Заполнить массив случайными числами (да / нет)? ");
    String Ansver = (Console.ReadLine());

    if (Ansver == "да") arr = FillRandom(arr);
    else arr = FillEntered(arr);
    return arr;
}

int[] FillRandom(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

int[] FillEntered(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"Введи число на позиции {i + 1}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int[] res = GetArray(Num);

System.Console.Write("[");
foreach (var item in res)
{
    System.Console.Write($"{item}, ");
}
System.Console.WriteLine("\b\b]");
