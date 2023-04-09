Console.Clear();
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int SetNumber(string text = "")
{
    System.Console.Write($"Enter number {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int number = SetNumber();
int sum = 0;
while (number > 0)
{
    sum += number % 10;
    number /= 10;
}
System.Console.WriteLine(sum);