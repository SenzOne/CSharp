int[] array = { 1, 3, 4, 345, 54, 23, 42 };
int n = array.Length;
int faind = 42;
int index = 0;
while (index < n)
{
    if (faind == array[index])
    {
        System.Console.WriteLine(index);
        break;
    }
    else
        index++;
}
