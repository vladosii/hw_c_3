///Задача 25: Напишите цикл, который принимает 
//на вход два числа (A и B) и возводит число A в натуральную степень B.

// void square(double a, double b){
//     double sq = Math.Pow(a, b);
//     Console.WriteLine(sq);
// }
// Console.Write("Введите число: ");
// double a = double.Parse(Console.ReadLine()!);
// Console.Write("Введите степень: ");
// double b = double.Parse(Console.ReadLine()!);

// square(a, b);


void square2(int a, int b){
    int sq = 1;
    for (int i = 1; i <= b; i++)
    {
        sq *= a;
    }

    Console.WriteLine(sq);
}

square2(2, 7);