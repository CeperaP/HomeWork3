//Задача21. Напишите программу,которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты точки A:");
Console.Write("x1=");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1=");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1=");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
Console.Write("x2=");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2=");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2=");
double z2 = Convert.ToInt32(Console.ReadLine());


double AB = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
Console.WriteLine($"Расстояние между точками: {Math.Round(AB,2)}"); 