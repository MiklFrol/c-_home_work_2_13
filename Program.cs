// Программа принимает число, и выводит третью цифру введенного числа

Console.Clear();

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);

int counterDigits = 0;
int tempNumber = number;
int thirdDigit = 0;

if (number < 100)
{
    Console.WriteLine("Третья цифра отсутствует!");
}
else
{
    while (tempNumber > 0)
{
    counterDigits++;
    tempNumber = tempNumber / 10;
}

while (counterDigits > 3)
{
    number = number / 10;
    counterDigits = counterDigits - 1;
}

thirdDigit = number % 10;

Console.WriteLine($"Третья цифра введенного цисла - {thirdDigit}");
}