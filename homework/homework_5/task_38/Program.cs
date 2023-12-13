// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Enter the number of array elements: ");
int CountElements = Convert.ToInt32(Console.ReadLine());

double MainMethod(int LenInputArr)
{
    double[] arr = CreatedArray(LenInputArr);
    arr = FillArray(arr);
    return FindDifference(arr);
}

// method for creating an array of length count
double[] CreatedArray(int count)
{
    double[] arr = new double[count];
    Console.WriteLine($"\nAn array of {count} elements has been created\n");
    return arr;
}

// method for filling an array with random double numbers
double[] FillArray(double[] SecondCucleArr)
{
    Console.WriteLine($"Added a number: \n");
    for (int i = 0; i < SecondCucleArr.Length; i++)
    {   
        double NewNumber = new Random().NextDouble();
        SecondCucleArr[i] = NewNumber;
        Console.WriteLine($"{NewNumber}");
    }
    return SecondCucleArr;
}


// a method for finding the difference between 
// the largest and smallest element of an array
double FindDifference(double[] ResArr)
{
    double Max = ResArr[0];
    double Min = ResArr[0];
    for (int i = 0; i < ResArr.Length; i++)
    {
        if(Min > ResArr[i]) Min = ResArr[i];
        if(Max < ResArr[i]) Max = ResArr[i];
    }
    return Math.Abs(Max - Min);
}   


Console.WriteLine($"\nDifference: {MainMethod(CountElements)}\n");
