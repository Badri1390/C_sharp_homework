﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

   System.Console.WriteLine("Введите число");
   int n = Convert.ToInt32(System.Console.ReadLine());
        Console.WriteLine(n>99 ? n.ToString()[2] : "третьей цифры нет");