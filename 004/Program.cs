// Написать программу копирования массива
Console.Clear();
Console.Write("- Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(""); 

Console.Write("Массив:        "); 
double[] array = new double[length];

for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(-100, 100);
}
Console.WriteLine("{0}", string.Join("; ", array));

Console.WriteLine(" "); 
Console.Write("Копия массива: "); 
double[] array1 = new double[length];
for (int i = 0; i < length; i++)
{
    array1[i] = array[i];
    Console.Write(array[i] + "; ");
}
