// тип данных[] имя = {значение1, значение2, ...}

// int[] array = {1, 2, 3, 4, 5};
// int[] array2 = new int[5]; // массив состоящий из 5 нулей
// int[] array3 = new int[] {0, 0, 0, 0, 0};
// int[] array3 = new int[5] {1, 0, 2, 0, 3};

int Max(int arg1, int arg2, int arg3)
{
    int res = arg1;
    if (arg2 > res) res = arg2;
    if (arg3 > res) res = arg3;
    return res;
}

int[] array = { 11, 21, 31, 41, 15, 61, 17, 18, 19 };
array[0] = 12;
System.Console.WriteLine(array[0]);
