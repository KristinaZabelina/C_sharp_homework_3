// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = 0;
int t = number;

while (number != 0)
{
    int number3 = number % 10;
    number = number / 10;
    number2 = number2 * 10 + number3;
}
Console.WriteLine(t == number2);

