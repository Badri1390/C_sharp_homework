// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите число от 100 до 999 включительно");
int num = Convert.ToInt32(System.Console.ReadLine());
int sum = (num / 10) % 10;
System.Console.WriteLine(sum);