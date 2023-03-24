//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7 

System.Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(System.Console.ReadLine());
int max = numberA;

if (max < numberB) max = numberB;
System.Console.Write( "Max =  ");
System.Console.WriteLine(max);