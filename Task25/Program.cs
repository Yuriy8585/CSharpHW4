// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В
// 3, 5 -> 243 (3*)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите значение числа: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите в какую степень возводить: ");
int b = int.Parse(Console.ReadLine()!);



double x = Math.Pow(a, b);

Console.WriteLine(x);