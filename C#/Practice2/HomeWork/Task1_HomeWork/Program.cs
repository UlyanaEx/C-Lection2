// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

int FindSecondDigit(int num)
{
    Console.WriteLine(num);
    int a = num / 10;
    a = a % 10;
    return a;
}

int b = FindSecondDigit(new Random().Next(100,1000));
Console.WriteLine(b);


