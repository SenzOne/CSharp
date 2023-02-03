// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Функция принимает пустой массив размера 3
// заполняет его значениями x, y, z
int[] EnterCoordinates(int[] EmptyArr)
{
    String[] NameCoord = { "x", "y", "z" };
    for (int i = 0; i < NameCoord.Length; i++)
    {
        Console.Write($"{NameCoord[i]}: ");
        EmptyArr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return EmptyArr;
}

// Функция принимает 2 массва размера 3
// Высчитывает дистанцию между точками
double СalculationDistance(int[] arr1, int[] arr2)
{
    double distance = Math.Round(Math.Sqrt(
        Math.Pow(arr2[0] - arr1[0], 2) +
        Math.Pow(arr2[1] - arr1[1], 2) +
        Math.Pow(arr2[2] - arr1[2], 2)), 2);

    return distance;
}

// Итоговая функция, которая запускает все вышестоящие
String FinalProcessing(int[] array1, int[] array2)
{
    Console.WriteLine("Введи координаты первой точки: ");
    int[] arr1 = EnterCoordinates(array1);

    Console.WriteLine("Введи координаты второй точки: ");
    int[] arr2 = EnterCoordinates(array2);

    double res = СalculationDistance(arr1, arr2);

    return $"Расстояние {res}";
}

int[] PointA = new int[3];
int[] PointB = new int[3];

System.Console.WriteLine(FinalProcessing(PointA, PointB));
