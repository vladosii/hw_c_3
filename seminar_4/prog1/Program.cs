int funs(int num){
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum+i;
    }
    Console.WriteLine(sum);
}

funs(5);