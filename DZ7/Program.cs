Console.WriteLine("Задание 25");        // Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Exponentiation(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }
    // int result = Math.Pow(numberA, numberB);
    return result;
}

System.Console.WriteLine();

  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(numberA, numberB);
  Console.WriteLine("Ответ: " + exponentiation);
System.Console.WriteLine();




Console.WriteLine("Задание 27"); // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите натуральное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numberN){

    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
  }

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);
System.Console.WriteLine();




Console.WriteLine("Задание 29"); // Напишите программу, которая задаёт массив из 8 элементов случайных целых чисел от 1 до 50 и выводит их на экран.

void fullArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,51);
    }
}

void printArray(int[] array)
{
    System.Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ,");
    }
    Console.Write("]");
}  

int[] nein = new int[8];
fullArray(nein); 
printArray(nein);




System.Console.WriteLine();
System.Console.WriteLine();
Console.WriteLine("необязательная задача SORT"); // Написать программу сортировки массива от большего к меньшему. Массив задается размерностью N с клавиатуры, далее заполняется случайными целыми числами от -100 до 100, выводится на экран. Сортируется, и затем опять выводится на экран.
int InputNum(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void fillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}

void printArr(int[] array)
{
    System.Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}

void Sort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPos = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPos])
            {
                maxPos = j;
            }
        }
        int temp = array[i];
        array[i] = array[maxPos];
        array[maxPos] = temp;
    }
}

int number = InputNum("Введите число: ");
int[] nain = new int[number];
fillArray(nain);
printArr(nain);
Sort(nain);

printArr(nain);



// int isPalindrome(int num)
// {
//     int n = num;
//     int rev = 0;
//     while (n == 0 )
//     {
//         int r = n % 10;
//         rev = rev * 10 + r;
//         n = n /10;
//     }
//     return (num = rev);
// }

// int main (int n)
// {
//     if (num == 0)
//     {
//         System.Console.WriteLine("weqweqwewq");
//     }
//     else
//     {
//         System.Console.WriteLine("Dadadasd");
//     }
// }   return 0 ;