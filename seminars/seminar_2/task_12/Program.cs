// task 12
// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int num1, num2;

System.Console.Write("Enter the first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter the second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

String res = (num1 % num2 == 0) ? "Кратно" : $"не кратно, остаток {(num1 % num2).ToString()}";
System.Console.WriteLine(res);
