// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78

System.Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите третье число: ");
int numberC = Convert.ToInt32(System.Console.ReadLine());
int max = numberA;

if (max < numberA) max = numberA;
if (max < numberB) max = numberB;
if (max < numberC) max = numberC;

System.Console.Write("max = ");
System.Console.WriteLine(max);
