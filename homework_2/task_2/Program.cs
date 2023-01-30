// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Write("Enter number: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());
int countZero = 0;


if (inputNumber < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else
{
    for (int i = 100; i < inputNumber; i *= 10)
    {
        countZero = i;
    }
    System.Console.WriteLine((inputNumber / (countZero / 100)) % 10); // 
}
