//  Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int DeleteSecondDigit(int num)
{
    Console.WriteLine(num);
    int a = num / 100;
    int b = num % 10;
    a = 10 * a + b;
    return a;
}

int c = DeleteSecondDigit(new Random().Next(100,1000));
Console.WriteLine(c);
