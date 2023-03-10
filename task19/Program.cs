//Задача 19. Напишите программу,которая принимает на вход пятизначное число
//и проверяет, является ли оно полиндромом.

Console.WriteLine("Введите пятизначное число");
int N = Convert.ToInt32(Console.ReadLine());
int x1 = 0;
int x2 = 0;
int x4 = 0;
int x5 = 0;

// Преобразуем из отриц. в положит.
if (N < 0)
{
    N = (N * -1);
}


//Отсекаем числа меншего разряда
if (N < 10000)
{
    Console.WriteLine("Вы ввели не пятизначное число");
    return;
}

//Отсекаем числа большего разряда
if (N > 99999)
{
    Console.WriteLine("Вы ввели не пятизначное число");
    return;
}

// Выделяем каждую цифру числа
x1 = N / 10000;
x2 = N / 1000;
x2 = x2 % 10;
x4 = N / 10;
x4 = x4 % 10;
x5 = N % 10;

if (x1 == x5 && x2 == x4)
{
    Console.WriteLine($"Число {N} является полиндромом ");
}
else
{
    Console.WriteLine($"Число {N} не является полиндромом");
}