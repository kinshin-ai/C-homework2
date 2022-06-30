// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("введите число от 100 до 999");
int num = Convert.ToInt32(Console.ReadLine());
string ShowNum2 (int fullnum)
{
  if (fullnum<100 ^ fullnum>999)
    {
  return ("введите трехзначное число");
    }
  else
    {
  int num1 = fullnum/100;
  int num2 = (fullnum-num1*100)/10;
  return (num2+" - вторая цифра числа");
    }
}
Console.WriteLine(ShowNum2(num));