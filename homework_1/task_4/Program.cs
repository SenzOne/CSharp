// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Реализация через цикл for
int inputNumber;

System.Console.Write("Enter number: ");
inputNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= inputNumber; i += 2)
    System.Console.Write(i + ",");

System.Console.WriteLine("\b \b");


// Реализация через цикл while
int iter = 2;

while (iter <= inputNumber)
{
    System.Console.Write(iter + ",");
    iter += 2;
}
System.Console.WriteLine("\b \b");
