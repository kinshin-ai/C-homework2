// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
string week (int day)
{
    if (day<1 ^ day>7)
    {
        return ("введите другое число");
    }
    else if (day>=1 && day < 6)
    {
        return ("сегодня будний день, пора на завод");
    }
    else
    {
        return ("сегодня выходной день, отлично");
    }
}
Console.WriteLine(week(num));