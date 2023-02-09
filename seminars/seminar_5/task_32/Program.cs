// Задача 32: Напишите программу замены элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// int[] numbers = {-4, -8, 8, 2};

// Console.WriteLine(string.Join(" ", numbers));
// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] *= -1; 
// }
// Console.WriteLine(string.Join(" ", numbers));


int[] numbers = new int[10];

// Console.WriteLine(string.Join(" ", numbers));
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(-9, 10);
}
Console.WriteLine(string.Join(" ", numbers));
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] *= -1;
}
Console.WriteLine(string.Join(" ", numbers));
