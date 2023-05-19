void funs(int nums){
    int sum = 0;
    for (int i = 1; i <= nums; i++)
    {
        sum = sum+i;
    }
    Console.WriteLine(sum);
}

funs(5);