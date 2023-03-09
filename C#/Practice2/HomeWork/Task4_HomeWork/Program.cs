//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
void Day(int num)
{
    Console.WriteLine(num);
    if ((num == 6) | (num == 7))
    {
        Console.WriteLine("Это выходной");
    }
    else if (num > 0 & num < 6)
    {
        Console.WriteLine("Это рабочий день");
    }
    else 
    {
        Console.WriteLine("Некорректные данные");
    }
}
Console.WriteLine("Введите число от 1 до 7");
string s_a = Console.ReadLine()!;
int a = int.Parse(s_a);
Day(a);


