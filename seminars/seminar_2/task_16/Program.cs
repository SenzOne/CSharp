// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да 25, 5 -> да
// 8,9 -> нет

System.Console.Write("Enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

String res = (num1 * num1 == num2 || num2 * num2 == num1) ? "Да" : "нет";
System.Console.WriteLine(res);
