// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Создаем переменную n
System.Console.Write("Введи число n: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введи показатель степени: ");
int DegreeIndicator = Convert.ToInt32(Console.ReadLine());

// Создаем функцию для заполнения массива
double[] MyDegree(double[] numbers)
{
    for (var i = 0; i < numbers.Length; i++) // цикл для перебора значений
    {
        numbers[i] = Math.Pow((i + 1), DegreeIndicator);
    }
    return numbers;
}


double[] GenerationArr(int number)
{
    // Создаем массив из 0 длинны n
    double[] arr = new double[number];

    // С помощью фкнуции MySqare перезаписываем пустой массив значениями квадратов
    arr = MyDegree(arr);
    return arr;
}

var res = GenerationArr(n);

for(int i = 0; i <  res.Length; i++)
{
    Console.WriteLine($"{i + 1}^{DegreeIndicator} = {res[i]}");
}
Console.WriteLine("\b\b");
