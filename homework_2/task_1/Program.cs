// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Write("Entered a three-digit number: ");
int input_number = 456; //Convert.ToInt32(Console.Read());

System.Console.WriteLine((input_number / 10) % 10);
