// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


System.Console.Write("Enter number: ");
ulong inputNumber = Convert.ToUInt64(Console.ReadLine());
ulong countZero = 0;

if (inputNumber > 100)
{
    for (ulong i = 100; i < inputNumber; i *= 10)
    {
        countZero = i;
    }
    ulong numbersAhead = countZero / 100;
    System.Console.WriteLine((inputNumber / (numbersAhead)) % 10);
}
else
    {
        System.Console.WriteLine("Третьей цифры нет");
    }
