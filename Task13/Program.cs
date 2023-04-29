// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = new Random().Next(10, 1000000);
Console.WriteLine("Вводное число: " +number);
int ThirdDigit(int number)
{   
    int result = -1;
    if (number>=100)
    {
        while (number>999)
        {
            number = number/10;
        }
            result = number%10;
    }
    return result;
}
Console.WriteLine("Третья цифра: " +ThirdDigit(number));
if (number<100)
Console.WriteLine("третьей цифры нет");
