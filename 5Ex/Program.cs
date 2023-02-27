int[] CreateIntArray()
{
    Console.Write("Введите длину массива ");
    int line = int.Parse(Console.ReadLine()!);

    Console.WriteLine();
    int[] array = new int[line];
    return array;
}
int[] FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 10);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" " + array[i]);
    }
}
 void Product(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if(i <= (array.Length/2-1))
        {
            int product=array[i]*array[(array.Length-1)-i];
            Console.WriteLine();
            Console.WriteLine($"Произведение {i+1} элемента и {array.Length-i} элемента равно {product}");
        }
    }
}
int[] numbers = CreateIntArray();
FillArray(numbers);
PrintArray(numbers);
Product(numbers);

