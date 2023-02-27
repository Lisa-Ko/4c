double[] CreateIntArray()
{
    Console.Write("Введите длину массива ");
    int line = int.Parse(Console.ReadLine()!);

    Console.WriteLine();
    double[] array = new double[line];
    return array;
}
void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] =Convert.ToDouble(new Random().Next(100, 1000))/100;
    }
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" " + array[i]);
    }
     Console.WriteLine();
}


double[] numbers = CreateIntArray();
FillArray(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);

double FindMax(double[] array)
{
    double max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    return max;
}
double FindMin(double[] array)
{
    double min = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
    return min;
}
double max = FindMax(numbers);
double min = FindMin(numbers);


Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

