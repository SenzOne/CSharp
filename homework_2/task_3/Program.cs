// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 7 -> да
// 6 -> да
// 1 -> нет


System.Console.Write("Enter number: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());

String res = (inputNumber < 6) ? "нет" : "да";

System.Console.WriteLine(res);
