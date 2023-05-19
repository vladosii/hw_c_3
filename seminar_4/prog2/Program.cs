//Напишите программу, которая принимает
//на вход число и выдаёт количество цифр в числе.

void countNumber(int nums){
    int count = 0;
    for (int i = 1; nums > 0; i++)
    {
        nums = nums/=10;
        count++;
    }
    Console.WriteLine(count);
}

countNumber(1421);