//Напишите программу, которая принимает на 
//вход пятизначное число и проверяет, является ли оно палиндромом.

// void polindrom(int num){
//     int first = (int)(num / Math.Pow(10, (int)Math.Log10(num)));
//     int last = num%10;

//     int two_two = num%10000;
//     int two = (int)(two_two / Math.Pow(10, (int)Math.Log10(two_two)));

//     int three_three = num%1000;
//     int three = (int)(three_three / Math.Pow(10, (int)Math.Log10(three_three)));

//     int four_four = num%100;
//     int four = (int)(four_four / Math.Pow(10, (int)Math.Log10(four_four)));

//     if (first == last && two == four){
//         Console.WriteLine("Полиндром!");
//     }else{
//         Console.WriteLine("Не полиндром!");
//     }
// }

// polindrom(12321);

void polind(int num){
    int n = num;

    int rev = 0;

    while (n)
    {
        int r = n %10;

        rev = rev *10+r;

        n = n/10;
    }

    Console.WriteLine(n);
    Console.WriteLine(r);
}

polind(1001);