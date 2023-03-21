// Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении 
// которых расположен наименьший элемент массива.

int[,] FillMass(int row, int column)
{
    int[,] array = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i,j] = new Random().Next(1, 100);
        }   
    }
    
    return array;
}

void PrintArray(int[,] array)
{
    int rowLen = array.GetLength(0);
    int colLen = array.GetLength(1);
    int countArray = rowLen*colLen;
    int[] min = new int[countArray];
    int count = 0;
    for (int i = 0; i < rowLen; i++)
    {
        for (int j = 0; j < colLen; j++)
        {
            min[count] = array[i,j];
            System.Console.Write($" {array[i,j]} ");
            count++;
        }
        System.Console.WriteLine("");
    }

    //Представляем двумерный массив 
    //как одномерный массив и находим минимальное значение
    int minNum = min[0];
    for (int i = 0; i < countArray; i++)
    {
        if (minNum > min[i])
            minNum = min[i];
        // System.Console.Write($" {min[i]} ");
    }
    System.Console.WriteLine($"Минимальное значение: {minNum}");

    //Теперь находим индекс минимального элемента в двумерном массиве
    int a = 0;
    int b = 0;
    for (int i = 0; i < rowLen; i++)
    {
        for (int j = 0; j < colLen; j++)
        {
            if (array[i,j] == minNum)
                System.Console.WriteLine($"Индекс минимального значения - {a = i+1}:{b = j+1} ");
        }
    }

    //Теперь зная индекс удаляем строку и столбец
    System.Console.WriteLine("Удалили строки и столбцы");
    for (int i = 0; i < rowLen; i++)
    {
        for (int j = 0; j < colLen; j++)
        {
            if (i != a-1 && j != b-1)
                System.Console.Write($" {array[i,j]} ");
        }
        System.Console.WriteLine("");
    }
}

int row = int.Parse(System.Console.ReadLine()!);
int column = int.Parse(System.Console.ReadLine()!);
int[,] NewArray = FillMass(row, column);
PrintArray(NewArray);