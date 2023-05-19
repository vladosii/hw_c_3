// 3. Задайте одномерный массив из 123 случайных чисел.
//    Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

void SumPosNeg(int[] arr)
{
    int pos, neg;
    pos = neg = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            pos += arr[i];
        else
            neg += arr[i];
    }
    Console.WriteLine($"Positive: {pos}, negative: {neg}");
}

void SumMassInterval(int[] arr){
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>10 && arr[i]<99){
            count++;
        }
    }
    Console.WriteLine($"Count: {count}");
}
Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Диапазон от");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Диапазон до");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
SumPosNeg(mass);

SumMassInterval(mass);