// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет 
// количество чётных чисел в массиве.

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

void massEven(int[] arr){
    int size = arr.Length;
    int count = 0;
    for (int i = 0; i < size; i++){
        if ((arr[i]%2) == 0){
            count++;
        }
    }
    Console.WriteLine($"Четных чисел: {count}");
}

Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Диапазон от");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Диапазон до");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);

massEven(mass);