Console.Clear();
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int num = 0;
int sum = 0;
while (number > 0)
{
    sum += number % 10;
    number /= 10;
}
System.Console.WriteLine(sum);