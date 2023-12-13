// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

System.Console.Write("Enter number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

String res = (num1 % 7 == 0 && num1 % 23 == 0) ? "да" : "нет";
System.Console.WriteLine(res);