// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//  4 -> да

System.Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(System.Console.ReadLine());

  if (numberA % 2 == 0)
  {
    System.Console.WriteLine("Чётное число");
  }

  else
  {
    System.Console.WriteLine("Нечётное число");
  }


