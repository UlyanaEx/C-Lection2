// у нас есть массив array, в котором n элементов. Найдём элемент, совпадающий снекоторым значением, который определяет пользователь

int[] array = { 11, 22, 80, 4, 57, 68, 76, 80 };
int n = array.Length;
int find = 80;
int index = 0;

while (index < n)
{
   if (array[index] == find)
{
    Console.WriteLine(index);
    break;
    }
      index++;
}









