Console.Clear();
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Write("Enter first number: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int B = Convert.ToInt32(Console.ReadLine());
int sqr = A;
for (int count = 1; count < B; ++count)
{
    sqr *= A;
}
Console.WriteLine($"Sqr = {sqr}");