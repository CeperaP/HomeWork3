//Задача №23.Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int N3 = 0;
int n = 0;

if(N == 0)
{
    Console.WriteLine(0);
}

for (n = 1; n <= Math.Abs(N); n++)
{
    N3 = n * n * n;
    if (N<0)
    {
        N3=N3 * -1;
    }
    Console.WriteLine(N3);
}
