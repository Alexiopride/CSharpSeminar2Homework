// Напишите программу, которая принимает на вход
//  трёхзначное число и на выходе показывает
//   вторую цифру этого числа.

Console.Write("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int GetSecondDigit(int num)
{
    int result = num / 10 % 10;
    return result;
}
if(number > 99 && number < 1000)
{
    Console.WriteLine(GetSecondDigit(number)); 
}
else
{
    Console.WriteLine("Вы ввели некорректное число, введите трёзначное число!"); 
}