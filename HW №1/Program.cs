//  Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] Array(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(100, 1000);

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
int ReadInt(string msg)
{
    System.Console.Write($"{msg} > ");
    return int.Parse(Console.ReadLine());
}

int Countable(int[] array)
{

    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}

int length = ReadInt("Введите длину массива ");
int[] array = Array(length);
PrintArray(array);
System.Console.WriteLine($"Количество четных чисел равна {Countable(array)}");
