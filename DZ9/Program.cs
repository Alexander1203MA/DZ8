Console.Write("Введите числа, через пробел: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Количество чисел которые больше 0: {count}");


Console.WriteLine ("Задача 43: Пересечение прямых y = k1 * x + b1, y = k2 * x + b2");

// Создаем метод для ввода числа пользователем

double InputNum (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}

double b1 = InputNum ($"Задайте b1: ");
double k1 = InputNum ($"Задайте k1: ");
double b2 = InputNum ($"Задайте b2: ");
double k2 = InputNum ($"Задайте k2: ");
    

double x = (b2 - b1) / (k1 - k2);
double y = k1 * (b2 - b1) / (k1 - k2) + b1;

Console.WriteLine ($"Точка пересечения прямых: ({x}, {y})");