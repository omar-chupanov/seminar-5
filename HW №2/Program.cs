// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] Array(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-10, 100);
    }
    return array;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
   System.Console.WriteLine();
}

int SumUncountable(int[] array)
{
    int uncountable = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1)
        {
            uncountable = uncountable + 1;
        }
    }
    return uncountable;
}

int ReadInt(string msg)
{
    System.Console.Write($"{msg} ");
    return int.Parse(Console.ReadLine());
}

int len = ReadInt("Введите длину массива >");
int[] array = Array(len);
PrintArray(array);
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {SumUncountable(array)}");