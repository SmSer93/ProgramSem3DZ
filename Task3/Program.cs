// Task 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0;
int n = number;

if (number > 9999 && number < 100000)
{
    num1 = n % 10;
    n = n / 10;
    num2 = n % 10;
    n = n / 10;
    num3 = n % 10;
    n = n / 10;
    num4 = n % 10;
    num5 = n / 10;
    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine($"{number} --> Да");
    }

    else { Console.WriteLine($"{number} --> Нет"); }
}
else Console.WriteLine("Введено не пятизначное число");