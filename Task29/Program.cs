// Напишите программу, которая задает массив из 8 элементов и выводит их на экран

Console.Clear();
Console.WriteLine("Enter number = ");

int i = int.Parse(Console.ReadLine()!);
var nums = i.ToString().Select(t=>int.Parse(t.ToString())).ToArray();

Console.WriteLine(i);