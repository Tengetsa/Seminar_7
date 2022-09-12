// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void Task47()
{
    Console.WriteLine("Введите количество строк массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[m, n];
    FillArray(array);
    PrintArray(array);
}

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
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

Task47();