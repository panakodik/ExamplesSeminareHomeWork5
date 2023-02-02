// Показать числа Фибоначчи
//F_{0}=0, F_{1}=1, F_{n}=F_{n-1}+F_{n-2},
//n>=2
//Console.WriteLine("Hello, World!");
Console.WriteLine("Конечное число последовательности Фибоначчи");
int number = int.Parse(Console.ReadLine()!);
Console.Write("Последовательность Фибоначчи ");
int N1 = 0;
Console.Write(N1 + " ");
int N2 = 1;
Console.Write(N2 + " ");
int sum = 0;
for (int i = 1; number >= sum; i++)
{
    sum = N1 + N2;
    Console.Write(sum + " ");
    N1 = N2;
    N2 = sum;
}