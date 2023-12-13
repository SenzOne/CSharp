// Собрать строку с числами от а до b, а <= b

// сторока из арифметической прогрессии
// цикл for
string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}


string NumbersRec(int a, int b)
{
    if(a < b) return $"{a} " + NumbersRec(a + 1, b);
    else return $"{a}";
}


string NumbersFor2(int a, int b)
{
    string res = string.Empty;
    for (int i = a; i >= b; i--)
    {
        res += $"{i} ";
    }
    return res;
}

string NombersRec2(int a, int b)
{
    if (a < b) return NombersRec2(a + 1, b) + $"{a} ";
    else return $"{a} ";
}

Console.WriteLine(NumbersFor(2, 10));
Console.WriteLine(NumbersRec(2, 10));
Console.WriteLine(NombersRec2(2, 10));

Console.WriteLine(NumbersFor2(10, 2));
