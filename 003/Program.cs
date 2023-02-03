// Написать программу масштабирования фигуры
/*Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"*/

Console.WriteLine("Программа масштабирования фигуры");
Console.WriteLine("Задайте координаты Х и У для 4-х точек фигуры");
Console.WriteLine("Задайте координаты Х1 и У1");
double X1 = Convert.ToDouble(Console.ReadLine()!);
double Y1 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Задайте координаты Х2 и У2");
double X2 = Convert.ToDouble(Console.ReadLine()!);
double Y2 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Задайте координаты Х3 и У3");
double X3 = Convert.ToDouble(Console.ReadLine()!);
double Y3 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Задайте координаты Х4 и У4");
double X4 = Convert.ToDouble(Console.ReadLine()!);
double Y4 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Координаты фигуры (" + X1 + ", " + Y1 + ") (" + X2 + ", " + Y2 + ") (" + X3 + ", " + Y3 + ") (" + X4 + ", " + Y4 + ")");
Console.WriteLine("Задайте коэфициент масштабирования N");
double N = Convert.ToDouble(Console.ReadLine()!);
double X11 = X1 * N;
double Y11 = Y1 * N;
double X22 = X2 * N;
double Y22 = Y2 * N;
double X33 = X3 * N;
double Y33 = Y3 * N;
double X44 = X4 * N;
double Y44 = Y4 * N;
Console.WriteLine("Координаты фигуры после масштабирования (" + X11 + ", " + Y11 + ") (" + X22 + ", " + Y22 + ") (" + X33 + ", " + Y33 + ") (" + X44 + ", " + Y44 + ")");