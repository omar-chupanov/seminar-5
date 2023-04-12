// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int ReadInt(string msg)
{
    System.Console.Write(msg );
    return int.Parse(Console.ReadLine());
}
double[] CreateArray(int length)
{
    double[] array = new double[length];
    Random rnd = new Random();
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

double Difference(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    return (max - min);
}



int length = ReadInt("Введите длину массива ");
double[] array = CreateArray(length);
PrintArray(array);
System.Console.WriteLine($"Разница между максимальным и минимальным элементом  {Difference(array)}");
