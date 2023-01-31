// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Воод данных
int num1, num2, num3;
int res;

System.Console.Write("Enter the first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter the second number: ");
num2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter the third number: ");
num3 = Convert.ToInt32(Console.ReadLine());

// Решение через тернарный оператор
res = num1 > num2 ? (num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3);
System.Console.WriteLine($"\nThe biggest number is: {res}\n");


// Решение через if else
if(num1 > num2 && num1 > num3)
{
    System.Console.WriteLine($"\nThe biggest number is: {num1}\n");
}
else if(num2 > num1 && num2 > num3)
{
    System.Console.WriteLine($"\nThe biggest number is: {num2}\n");
}
else
{
    System.Console.WriteLine($"\nThe biggest number is: {num3}\n");
}
