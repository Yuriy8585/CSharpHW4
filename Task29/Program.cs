// Напишите программу, которая задает массив из 8 элементов и выводит их на экран

Console.Clear();
Console.WriteLine("Enter number = ");

//int i = int.Parse(Console.ReadLine()!);
//var nums = i.ToString().Select(t=>int.Parse(t.ToString())).ToArray();

//Console.WriteLine(nums);
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)
{
int count = array.Length;
    for (int i = 0; i < count; i++)
    {
    Console.Write($"{array[i]}");
    }
Console.WriteLine();
}
PrintArray(arr);
