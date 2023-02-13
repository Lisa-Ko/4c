int a = 0;
int [] numbers = new int [123];
for (int i = 0; i < numbers.Length; i++)
{ numbers[i] = new Random().Next(0, 1000);}
for (int i = 0; i < numbers.Length; i++)
 {Console.Write(numbers[i] + "|");}
for (int i = 0; i < numbers.Length; i++)
{
    if ((numbers[i] >= 10) && (numbers[i] <= 99)) a=a+1;
}
Console.WriteLine($"В массиве в 123 числа в промежутке [10;99] лежат {a} чисел");