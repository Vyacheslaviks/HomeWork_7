/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
*/

//Тело программы

Console.WriteLine("Введите индексы искомого элемента: ");
int NumRow = InputInt();
int NumColumn = InputInt();

int[,] local_array = GenRandomArray(5, 3);
PrintArray(local_array);

try
{
    Console.Write($"Искомый элемент имеет значение: {SearcElement(local_array, NumRow, NumColumn)}");
}
catch(Exception ms)
{
    Console.WriteLine(ms.Message);
}

//Методы

int InputInt()
{
    bool isParse = int.TryParse(Console.ReadLine(), out int number);

    if (isParse)
    {
        return number;
    }
    else
    {
        throw new ArgumentException("Введено некорректное значение!");
    }
}

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

int SearcElement(int[,] array, int Row, int Column)
{
    int element = 0;

    if (Row >= 0 && Row < array.GetLength(0) && Column >= 0 && Column < array.GetLength(1))
    {
        element = array[Row, Column];
    }
    else
    {
        throw new Exception("Такого элемента нет!");
    }

    return element;
}