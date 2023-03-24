// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// System.Console.WriteLine("Введите пятизначное число: ");
// int num = Convert.ToInt32(System.Console.ReadLine());
// if(num.ToString()[0] == num.ToString()[4] && num.ToString()[1] == num.ToString()[3]){
//     System.Console.WriteLine("Да");
// }
// else{
//     System.Console.WriteLine("нет");
// }

System.Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(System.Console.ReadLine());
if (num < 10000){
    System.Console.WriteLine("Чё творишь?!!!");
}
else if(num.ToString()[0] == num.ToString()[4] && num.ToString()[1] == num.ToString()[3]){
    System.Console.WriteLine("Да");
}
else{
    System.Console.WriteLine("нет");
}

