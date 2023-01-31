// Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.Write("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int res = (number1 > number2) ? number1 : number2;

System.Console.WriteLine($"The number {res} is greater!");
