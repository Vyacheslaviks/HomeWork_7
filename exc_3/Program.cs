/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
*/

//Тело программы

int[,] local_array = GenRandomArray(5, 5);
PrintArray(local_array);
string out_array = string.Empty;
out_array = string.Join(", ", CalculateArithmeticMean(local_array));

Console.WriteLine($"[{out_array}]");

//Методы

int[,] GenRandomArray(int CountRows, int CountColumns)
{
    int[,] array = new int[CountRows, CountColumns];
    Random rand = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(0, 10);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}    ");
        }
        Console.WriteLine();
    }
}

double[] CalculateArithmeticMean(int[,] Array)
{
    double[] Mean = new double[Array.GetLength(1)];
    double ColumnsSum = 0.0;

    for (int j = 0; j < Array.GetLength(1); j++)
    {
        ColumnsSum = 0.0;
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            ColumnsSum += Array[i, j];
        }
        Mean[j] = ColumnsSum / Array.GetLength(0);
    }

    return Mean;
}