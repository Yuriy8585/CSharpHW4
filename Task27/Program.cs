// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Enter number = ");

string num = Console.ReadLine();
int len = num.Length;
int[] nums = new int[len];
int sum = 0;
int count = 0;
while (count < len)
{
    nums[count] = Convert.ToInt32(num[count].ToString()); // перевести в отдельные значения
    count++;
}
for (int i = 0; i < len; i++)
    sum += nums[i];

Console.WriteLine(sum);