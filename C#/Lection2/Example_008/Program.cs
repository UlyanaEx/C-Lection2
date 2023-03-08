// Ищем максимум из 9 чисел

int a1 = 7;
int b1 = 3;
int c1 = 9;

int a2 = 110;
int b2 = 2;
int c2 = 4;

int a3 = 25;
int b3 = 0;
int c3 = 8;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;
if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;
if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max);
