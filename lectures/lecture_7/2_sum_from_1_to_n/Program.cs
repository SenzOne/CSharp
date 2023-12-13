// Сумма чисел от 1 до n

// int SumRec(int n)
// {
//     if (n == 0) return 0;
//     else return n + SumRec(n - 1);
// }

// Console.WriteLine(SumRec(10));

// // Факториал числа
// int Factorial(int n)
// {
//     if (n == 0) return 1;
//     else return n * Factorial(n - 1);
// }

// System.Console.WriteLine(Factorial(1));

// А в степени n
int RowerRec(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0)return RowerRec(a * a, n / 2);
    else return RowerRec(a, n - 1) * a;
}

System.Console.WriteLine(RowerRec(2, 10));