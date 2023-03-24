//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
int number = inputNumber("Задайте кол-во чисел");
int[] array = new int[number];
int res = Result(array);
System.Console.WriteLine($"Кол-во чисел больше нуля: {res}");

int Result(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {

        arr[i] = inputNumber("Введите число");
        if (arr[i] > 0)
        {
            count++;

        }

    }
    System.Console.WriteLine($"[{String.Join(", ", arr)}]");
    return count;

}

int inputNumber(string str)
{
    int number;
    string text;

    while (true)
    {
        System.Console.WriteLine(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}


//=======================================================================

// Console.Clear();
// int positive_num;
// print(inputNumber("Введите число!", out positive_num));
// System.Console.WriteLine($"Количество введенных положительных чисел: {positive_num}");



// int[] inputNumber(string str, out int count)
// {
//     count = 0;
//     int num = 1;
//     int number;
//     string text;
//     int[] numbers = { }; 
//     System.Console.WriteLine("Наберите \"стоп\" или \"stop\" (регистр не важен) для остановки ввода чисел");
//     while (num == 1)
//     {
//         Console.WriteLine(str);
//         text = Console.ReadLine();
//         if (int.TryParse(text, out number))
//         {
//             if (number > 0)
//                 count += 1;
//             numbers = numbers.Append(number).ToArray();// добавить число в массив
//         }
//         else if (text.ToLower() == "stop" || text.ToLower() == "стоп")
//         {
//             return numbers;
//         }
//         else
//             Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
//     }
//     return numbers;

// }


// void print(int[] arr)
// {
//     System.Console.WriteLine($"[{String.Join(", ", arr)}]");
// }
//==================================================================================

// int s = 1;

// void Fun(int b)
// {
//     int res = b * 5;
// }

// Fun(s);

// int num = 3;


// void Funs(out int q)
// {
//     q = 6;

// }

// Funs(out num);
// System.Console.WriteLine(s);
// System.Console.WriteLine(num);
