// Ищем максимум из 9 чисел

int Max (int Arg1, int Arg2, int Arg3)
{
    int result = Arg1;
    if (Arg2 > result) result = Arg2;
    if (Arg3 > result) result = Arg3; 
    return result;
}

int[] array = {11, 172, 13, 74, 55, 66, 27, 78, 90};
int Maxresult = Max (
    Max (array[0], array[1], array[2]),
    Max (array[3], array[4], array[5]),
    Max (array[6], array[7], array[8])
);

Console.WriteLine(Maxresult);
