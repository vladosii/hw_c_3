//  Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку 
// с наименьшей суммой элементов.

void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    System.Console.WriteLine("_________________");
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

void sumElementsColumn(int[,] arr)
{
    System.Console.WriteLine("Сумма всех Строк");
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int count = 0;
    int[] sum = new int[column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            sum[i] += arr[count, j];
        }
    System.Console.WriteLine($"{sum[i]} ");
    count++;
    }

    //Находим наименьшую сумма
    int min = sum[0];
    for (int i = 0; i < sum.Length; i++)
    {
        if (min > sum[i])
            min = sum[i];
    }

    //Находим строку
    int xCount = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        if (min == sum[i])
            xCount = i+1;
    }

    System.Console.WriteLine($"\nНаименьшая сумма {min} строка {xCount}");
}

int row_num = int.Parse(Console.ReadLine()!);
int column_num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);


int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);

sumElementsColumn(mass);