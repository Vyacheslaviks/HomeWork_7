//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//Тело программы

PrintArray(GenRandomArray(5,5));


//методы

double[,] GenRandomArray(int n, int m)
{
    double[,] array = new double[n,m];
    Random rand = new Random();

    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < m; j++)
        {
            array[i,j] = rand.NextDouble() * 10;
            array[i,j] = Math.Round(array[i,j], 2);
        }
    }

    return array;
}

void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}   ");
        }
        Console.WriteLine();
    }
}