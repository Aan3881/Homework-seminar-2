// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число: ");
bool day0(int day)
{
    return day == 6 || day == 7;
}
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 7)
{
    if (day0(num)) Console.WriteLine($"{num} да");
    else Console.WriteLine($"{num} нет");
}
else Console.WriteLine("Не корректное значение ");