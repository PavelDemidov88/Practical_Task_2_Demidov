// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
//Console.WriteLine("Введите день");

Console.Write("Введите день ");
string NumDay = Console.ReadLine();

if (NumDay == "1")
{
    Console.WriteLine("Понедельник");
}
if (NumDay == "2")
{
    Console.WriteLine("Вторник");
}
if (NumDay == "3")
{
    Console.WriteLine("Среда");
}
if (NumDay == "4")
{
    Console.WriteLine("Четверг");
}
if(NumDay == "5")
{
    Console.WriteLine("Пятница");
}
if (NumDay == "6")
{
    Console.WriteLine("Выходной, суббота!");
}
if (NumDay == "7")
{
    Console.WriteLine("Выходной, воскресенье!");
}