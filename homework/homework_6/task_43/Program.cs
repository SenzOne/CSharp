// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Prompt(string massege)
{
    System.Console.Write(massege);
    double result = Convert.ToDouble(Console.ReadLine());
    return result;
}

void GetPosicion(double k1 = 5, double k2 = 9, double b1 = 2, double b2 = 4)
{
    if (k1 == k2) Console.WriteLine("Прямые параллельны!");
    else
    {
        double xCoefficient = (b1 - b2) / (-k1 + k2);
        System.Console.WriteLine($"x = {xCoefficient}");

        double yCoefficient = k1 * xCoefficient + b1;
        System.Console.WriteLine($"y = {yCoefficient}");
    }
}

double k_1 = Prompt("Введи k1: ");
double b_1 = Prompt("Введи b1: ");

double k_2 = Prompt("Введи k2: ");
double b_2 = Prompt("Введи b2: ");
GetPosicion(k_1, k_2, b_1, b_2);
// GetPosicionX();
