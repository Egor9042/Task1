//Напишите программу, которая принимает на вход трёхзначное число и удаляет вторую цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int firstDigit = number / 100;
int thirdDigit = number % 10;
int result = firstDigit * 10 + thirdDigit;

Console.WriteLine(result);