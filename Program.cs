// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool CheckNumber(int num)
{
    int n1 = num / 10000;
    int a = num % 10000;
    int n2 = a / 1000;
    int n4 = num % 100;
    int n5 = num % 10;

    if((n1==n5)||(n2==n4))
        return true;
    else return false;
}

Console.Write("Введите число для проверки: ");
int num = Convert.ToInt32(Console.ReadLine());

bool result = CheckNumber(num);

if (result)
    Console.WriteLine($"Число {num} является палиндромом");
else
    Console.WriteLine($"Число {num} не является палиндромом");
*/


// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double LenSegment(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double dx = x1-x2;
    double dy = y1-y2;
    double dz = z1-z2;
    return Math.Sqrt(dx*dx + dy*dy + dz*dz);
}

Console.Write("Введите x координату 1 точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y координату 1 точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z координату 1 точки: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите x координату 2 точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y координату 2 точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z координату 2 точки: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Длина отрезка ({x1},{y1},{z1}) ({x2},{y2},{z2}) равна {LenSegment(x1, y1, z1, x2, y2, z2)}");
*/


// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Qubestable(int n)
{
    int i = 1;
    while (i <= n)
{
    Console.WriteLine($"куб числа {i} = {i*i*i}");
    i++;
}
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Qubestable(num);


