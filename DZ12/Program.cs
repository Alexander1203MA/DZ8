System.Console.WriteLine("Задача 64"); //Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalToNum(number, count);

void NaturalToNum(int t, int count)
{
    if (count > t)
    {
        return;
    }
    else
    {
        NaturalToNum(t, count + 1);
        Console.Write(count + " ");
    }
}
Console.WriteLine();
Console.WriteLine();


System.Console.WriteLine("Задача 66");//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

SumFromMToN(m, n);

void SumFromMToN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}
Console.WriteLine();
Console.WriteLine();

System.Console.WriteLine("Задача 68");// Напишите программу вычисления функции Аккермана с помощью рекурсии
Console.Write("Введите число M: ");
int z = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int x = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(z,x);


void AkkermanFunction(int z, int x)
{
    Console.Write(Akkerman(z, x)); 
}

int Akkerman(int z, int x)
{
    if (z == 0)
    {
        return x + 1;
    }
    else if (x == 0 && z > 0)
    {
        return Akkerman(z - 1, 1);
    }
    else
    {
        return (Akkerman(z - 1, Akkerman(z, x - 1)));
    }
}