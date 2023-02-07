// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


System.Console.Write("Введи число: ");
int Inputnumber = Convert.ToInt32(Console.ReadLine());

int GetSum(int num)
{
    int res = 0;
    while(num > 0)
    {
        res = res + (num % 10);
        num /= 10;
    }
    return res;
}

System.Console.WriteLine(GetSum(Inputnumber));
