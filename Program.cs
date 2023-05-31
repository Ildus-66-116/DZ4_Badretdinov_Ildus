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

Console.Clear();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 101);
Console.WriteLine($"-> [{string.Join(", ", array)}]");
