// Не использовать Math.Pow
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Clear();
// Console.Write("Введите число A: ");
// double a = double.Parse(Console.ReadLine()!);
// Console.Write("Введите число B: ");
// int b = int.Parse(Console.ReadLine()!);
// double c = 1;
// for(int i = 0; i < b; i++) c = c * a;
// Console.Write($"{a}, {b} -> {c}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Clear();
// Console.Write("Введите число: ");
// string number = Console.ReadLine()!;
// int summa = 0;
// for (int i = 0; i < number.Length; i++)
//     summa = summa + Convert.ToInt32(number[i].ToString());
// Console.WriteLine($"{number} -> {summa}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Console.Clear();
// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 101);
// Console.WriteLine($"-> [{string.Join(", ", array)}]");


// Суперсдвиг
// Входные данные
// Первая строка входного файла INPUT.TXT содержит натуральное число N, 
// во второй строке записаны N целых чисел Ai, а в последней – целое число K. (1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100).

// Выходные данные
// В выходной файл OUTPUT.TXT выведите полученную последовательность.


Console.Clear();
Console.Write("Введите количество элементов: ");
int n = int.Parse(Console.ReadLine()!);
while(n > 100000 || n < 1)
     {
     Console.Write("Вы ошиблись! \nВведите от 1 до 100 000 число: ");
     n = int.Parse(Console.ReadLine()!);
     }
Console.Write("Введите число на сколько нужно сдвинуть: ");
int k = int.Parse(Console.ReadLine()!);
while(k > 100000)
     {
     Console.Write("Вы ошиблись! \nВведите от 0 до 100 000 число: ");
     k = int.Parse(Console.ReadLine()!);
     }
int[] array = new int[n];
for(int i = 0; i < n; i++) array[i] = new Random().Next(0, 101);
Console.WriteLine(n);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.Write(k);
Console.WriteLine();
int k1 = 1;
if(k > 0) 
     {k1 = n-k;
     for(int i = 0; i < k; i++)
    {
    int temp = array[i];
//     for(int j = i+1; j < k; j++)
//           {
//           int temp1 = array[j];
//           array[j] = array[i];
//           array[j+1] = temp1;
//           }
    array[i] = array[k1+i];
    array[k1+i] = temp;
    }
     }
Console.WriteLine($"Результат: [{string.Join(", ", array)}]");
// else k1 = k * -1;
