// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("введите число: ");
int x = Convert.ToInt32(System.Console.ReadLine());
for(int i = 1; i <= x; i++){
  System.Console.Write(i * (i * i) + " ");
}
// System.Console.WriteLine("введите число: ");
// int x = Convert.ToInt32(System.Console.ReadLine());
// if(x < 0){
//   System.Console.WriteLine("не гони");
// }
// for (int i = 1; i <= x; i++)
// {

//     System.Console.Write(i * (i * i) + " ");

// }