Console.Clear();
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int FirstNumber(string text = "")
{
    System.Console.Write($"Enter number A {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int NumberA = FirstNumber();
int SecondNumber(string text = "")
{
    System.Console.Write($"Enter number B {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int NumberB = SecondNumber();
int MethodSqr(int number)
{
    int sqr = NumberA;
    for (int count = 1; count < NumberB; ++count)
    {
        sqr *= NumberA;
    }
    Console.WriteLine($"sqr = {sqr}");
    return sqr;
}
MethodSqr(NumberB);