// Задайте две матрицы. Напишите 
// программу, которая будет
// находить произведение двух матриц.

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

int[,] OneMass(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

int[,] TwoMass(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

int[,] NewMass(int[,] FirstMass, int[,] LastMass)
{
    int row = FirstMass.GetLength(0);
    int column = FirstMass.GetLength(1);

    int[,] newMass = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
           newMass[i,j] = FirstMass[i,j]*LastMass[i,j];
        }
    }
    return newMass;
}

System.Console.WriteLine("Первая матрица");
int[,] FirstMass = OneMass(3,3,1,10);
Print(FirstMass);

System.Console.WriteLine("Вторая матрица");
int[,] LastMass = TwoMass(3,3,1,10);
Print(LastMass);

System.Console.WriteLine("Произведение матриц");
int[,] ThreeMass = NewMass(FirstMass, LastMass);
Print(ThreeMass);