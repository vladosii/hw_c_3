// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

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

void massDiff(int[] arr){
    int size = arr.Length;
    int max = 0;
    int min = arr[0];
    for (int i = 0; i < size; i++){
        if (arr[i] > max){
            max = arr[i];
        }
    }
    for (int i = 0; i < size; i++){
        if (arr[i] <= min){
            min = arr[i];
        }
    }

    int diff = max - min;

    Console.WriteLine($"Максимальный: {max}");
    Console.WriteLine($"Минимальный: {min}");
    Console.WriteLine($"{max} - {min} = {diff}");
}

Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Диапазон от");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Диапазон до");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);

massDiff(mass);