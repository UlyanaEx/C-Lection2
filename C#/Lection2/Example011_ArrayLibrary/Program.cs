﻿
int[] array = new int[10];
void FillArray(int[]collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[]col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
int index = collection.Length;
int count = 0;
int position = 0;
while (index < count)
{
 If(collection[index] == find) {
 position = index;
 }
index++;
}
Return position;
}

FillArray(array);
PrintArray(array); 
Console.WriteLine();
int pos = IndexOf(array, 4);
Console.WriteLine(pos);