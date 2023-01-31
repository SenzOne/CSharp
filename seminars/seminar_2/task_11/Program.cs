// task 11 
// Напишите программу, которая выводит случайное 
// трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int RandomInt = new Random().Next(100, 1000);
System.Console.WriteLine($"The hidden number: {RandomInt}");

System.Console.WriteLine(RandomInt / 100 * 10 + RandomInt % 10);
