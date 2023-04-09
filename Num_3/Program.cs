Console.Clear();
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int []Array(int length)
{
    int []array = new int[length];
    for (int index = 0; index < length; index++)
    {
        array[index] = new Random().Next(1, 100);
    }
    return array;
}

void Print( int []array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; ++i)
    {
        Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}
int length = 8;
int []array = Array(length);
Print(array);
