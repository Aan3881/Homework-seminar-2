// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int number(int num2)
{
    while (num2 > 1000)
    {
        num2 = num2 / 10;
        num1 = num2;
    }

    return num2;
}

int number2(int num)
{
    int n = num % 10;
    return n;
}

if (num1 < 100) Console.WriteLine("Третьей цифры нет");
else
{
    int a = number(num1);
    int result = number2(a);
    Console.WriteLine($"{result}");
}
