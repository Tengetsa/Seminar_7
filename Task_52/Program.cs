// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void Task52()
{
    Console.WriteLine("Введите количество строк массива: ");
    int lines = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[lines, columns];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    ArithmeticMean(array);
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
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

void ArithmeticMean(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double result = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            result += array[i, j];
        }
        result = result / array.GetLength(0);
        Console.Write($"{Math.Round(result, 1)}; \t");
    }
}

Task52();
