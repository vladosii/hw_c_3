// Задайте двумерный массив размера m на n, каждый
// элемент в массиве находится по формуле: Aₙₙ = m+n.
// Выведите полученный массив на экран.

void mas(int n, int m)
{
    int[,] massiv = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            int massiv = new Random().Next(1, 100);
            mas[i,j] = num;
            Console.WriteLine($"mas[i,j]");
        }
    }
}

mas(3,3);