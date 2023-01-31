// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Решение через тернарный оператор
int inputNumber;

System.Console.Write("Enter the number: ");
inputNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine((inputNumber % 2 == 0) ? true : false);


// Решение через if else 
if (inputNumber % 2 == 0)
{
    System.Console.WriteLine($"The number {inputNumber} is even");
}
else
{
    System.Console.WriteLine($"The number {inputNumber} is odd");
}

