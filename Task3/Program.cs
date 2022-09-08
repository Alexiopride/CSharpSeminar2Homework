// Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли
//   этот день выходным.

Console.WriteLine("Введите число от 1 до 7:");
int number = Convert.ToInt32(Console.ReadLine());

void weekend(int num)
{
   if (num > 0 && num < 8)
   {
      if (num == 6 || num == 7) 
      // "||" - или. "&&" - "амперсант" И.
      {
         Console.WriteLine("Выходной день"); 
      }
      else 
      {
         Console.WriteLine("Рабочий день"); 
      }
   }
   else 
   {
      Console.WriteLine("Вы ввели неверное число."); 
   }
}
   
weekend(number);
