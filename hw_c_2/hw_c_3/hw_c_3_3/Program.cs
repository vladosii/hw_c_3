//Задача 23. Напишите программу, которая 
//принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N

void square(double num){
    for (int i = 1; i <= num; i++)
    {
        double square = Math.Pow(i,3);
        Console.WriteLine(square);
    }
}

square(5);
