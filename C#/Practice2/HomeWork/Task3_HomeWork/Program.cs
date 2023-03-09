// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

void ThirdDigit(int num)
{
    Console.WriteLine(num);
    if (num < 100)
    {
        Console.WriteLine("третьей цифры нет");
    }
    else
    {
        while (num > 999)
        {
            num = num / 10;
        }
        Console.WriteLine(num % 10);
    }
}

ThirdDigit(new Random().Next());


