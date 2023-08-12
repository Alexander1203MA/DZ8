Console.WriteLine("Задание 10");
Console.Write("введите первое трехзначное число :");
int n = Convert.ToInt32(Console.ReadLine()) ;
int second = n /10 % 10 ;
Console.Write($"Вторая цифра полученного числа это :{second}");

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Задание 13");
Console.Write("Введите число :");
int n1 = Convert.ToInt32(Console.ReadLine()) ;
int threechislo(int n1)
{
    int result = -1;
        if (n1 >= 100)
            {
                while (n > 999)
                {
                    n1 = n1 / 10;
                }
                result = n1 % 10;
            }
            return result; 
}
if (threechislo(n1) == -1)
    Console.WriteLine("Третьей цифры в этом числе нет");
else
    Console.WriteLine($"третья цифра заданного числа: {threechislo(n1)}");


Console.WriteLine("");
Console.WriteLine("Задание 15");
Console.Write("Введите день недели :");
int n2 = Convert.ToInt32(Console.ReadLine()) ;
void Day(int n2)
{
    if (n2 == 6 || n2 == 7)
    {
        System.Console.WriteLine("У нас выходной день.");
    }
    else System.Console.WriteLine("Рабочий день."); 
}
Day(n2) ;