// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце

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
    System.Console.WriteLine("___Сред. арифмет.____");
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int count = 0;
    int[] sum = new int[column];
    for (int j = 0; j < column; j++)
    {
        for (int i = 0; i < row; i++)
        {
            sum[j] += arr[i, count];
        }
    // System.Console.Write($" {sum[j]} ");
    System.Console.Write($"{sum[j]/column} ");
    count++;
    }
}

int row_num = int.Parse(Console.ReadLine()!);
int column_num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);


int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);

sumElementsColumn(mass);