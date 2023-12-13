// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Введи число: ");
int n = Convert.ToInt32(Console.ReadLine());


if (n > 0)
{
    int a = -n;

    while (a <= n)
    {
        Console.Write($" {a}");
        a++;
    }
}
else if (n < 0)
{
    int a = -n;

    while (a >= n)
    {
        Console.Write($"{a} ");
        a--;
    }
}
