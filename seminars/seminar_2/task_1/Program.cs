﻿
// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int num = new Random().Next(10, 100);
System.Console.WriteLine($"The hidden number: {num}");
int res = num / 10 > num % 10 ? num / 10 : num % 10;
System.Console.WriteLine($"The largest digit of the number {res}");