// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.Write("Введи основание степени: ");
int num1 = Convert.ToInt32(Console.ReadLine()); 
System.Console.Write("Введи показатель степени: ");
int num2 = Convert.ToInt32(Console.ReadLine()); 


int Exponentiation(int BasisOfDegree, int DegreeIndicator)
{
    int res = 1;
    for (int i = 0; i < DegreeIndicator; i++)
    {
        res = res * BasisOfDegree;
    }
    return res;
}

System.Console.WriteLine(Exponentiation(num1, num2));
