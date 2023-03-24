//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] arr = Auto(6, 5, 20);
System.Console.WriteLine("[" + string.Join(" | ", arr) + "]");

int[] Auto(int num, int num1, int num2)
{
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(num1, num2);
    }
    return arr;
} 

