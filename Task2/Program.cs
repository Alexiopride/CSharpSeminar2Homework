// Напишите программу, которая выводит третью цифру
//  заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); 

void GetThirdDigit(int num)
{
    if (num >= 100)
    {
        while (num > 999) num = num / 10;
        Console.WriteLine(num % 10);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}

GetThirdDigit(number);