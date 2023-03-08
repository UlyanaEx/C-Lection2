// Ищем максимум из 9 чисел

int Max (int Arg1, int Arg2, int Arg3)
{
    int result = Arg1;
    if (Arg2 > result) result = Arg2;
    if (Arg3 > result) result = Arg3; 
    return result;
}

int a1 = 7;
int b1 = 13;
int c1 = 9;

int a2 = 110;
int b2 = 2;
int c2 = 4;

int a3 = 25;
int b3 = 0;
int c3 = 800;

int Max1 = Max (a1, b1, c1);
int Max2 = Max (a2, b2, c2);
int Max3 = Max (a3, b3, c3);
int MaxResult = Max (Max1, Max2, Max3);

Console.WriteLine(MaxResult);
