// Напишите программу, которая выводит третью слева
// цифру заданного числа или сообщает, что третьей
// цифры нет.

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0)
{
    num = num * -1;
}

if (num < 100)
{
    Console.WriteLine("Третей цифры нет");
}
else
{
    while (num > 999)
    {
    num = num / 10;
    }
    Console.WriteLine(num % 10);
}