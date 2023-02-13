int [] numbers = new int [8];
for (int i = 0; i < numbers.Length; i++)
{ numbers[i] = new Random().Next(-100, 100);}
 for (int i = 0; i < numbers.Length; i++)
 {Console.Write(numbers[i] + "|");}
int a = 0; int b = 0;
for (int i = 0; i < numbers.Length; i++)
{if (numbers[i]%2==0) a = a+1;else b = b+1;}
Console.WriteLine($"Количество четных чисел равно {a}, а количество нечетных - {b}");