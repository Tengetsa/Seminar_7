// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

void Task50()
{
    Console.WriteLine("Введите количество строк массива: ");
    int lines = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов массива: ");
    int colums = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[lines, colums];

    FillArray(array);
    PrintArray(array);
    ElementIndex(array);
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ElementIndex(int[,] array)
{
    Console.WriteLine("Введите позицию по строкам массива: ");
    int linePosition = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите позицию по столбцам массива: ");
    int columnPosition = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    if (linePosition < array.GetLength(0) + 1 & columnPosition < array.GetLength(1) + 1)
    {
        Console.WriteLine(array[linePosition - 1, columnPosition - 1]);
    } 
    else
    {
    Console.WriteLine($"{linePosition}{columnPosition} -> такого числа в массиве нет");
    }
}

Task50();
