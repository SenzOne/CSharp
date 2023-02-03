// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Я решил немного усложнить задачу, и сделать так, чтобы программа обрабатывала
// палиндромом любой длинны но так, как нельзя пользоваться срезами и метадами массивов
// пришлошь испольховать большое количество циклов 

// Функция преобразовывает аргумент в массив и возвращает его
int[] GenerateArrFromNum(int number)
{
    int number_count = number;       // создаем копию числа, которое будем уменьшать
    int conut = 0;                   // количество знаков в number
    while (number_count > 0)
    {
        number_count /= 10;
        conut++;
    }

    int[] arr = new int[conut];      // создаем массив длинны count, которое получили в прошлом цикле  
    for (int i = number, j = 0; i > 0; i /= 10, j++)
    {
        arr[j] = i % 10;             // заполняем отдельными числами массив
    }
    return arr;
}


// Функция проверяет равенство 1 и последнего элемента, затем 2 и предпоследнего
// если они равны возвращает true
bool ItsTrue(int[] coll)
{
    bool ItsTrue = true;
    for (int i = 0, j = coll.Length - 1; i < coll.Length; i++, j--)
    {
        ItsTrue = coll[i] == coll[j] ? true : false;
    }
    return ItsTrue;
}

// Итоговая функция, которая запускает все вышестоящие
String FinalProcessing(int number)
{
    bool x = ItsTrue(GenerateArrFromNum(number));
    return x ? $"{number} - палиндромом" : $"{number} - не палиндромом";
}


Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FinalProcessing(num));
