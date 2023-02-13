int answer = 0;
int [] numbers = new int [5];
for (int i = 0; i < numbers.Length; i++)
{ numbers[i] = new Random().Next(0, 100);}
for (int i = 0; i < numbers.Length; i++)
 {Console.Write(numbers[i] + "|");}
for (int i = 0; i < numbers.Length; i++)
{ if (i%2!=0) answer = numbers[i] + answer; }
Console.WriteLine();
Console.WriteLine($"Сумма чисел на нечетных позициях равна {answer}");