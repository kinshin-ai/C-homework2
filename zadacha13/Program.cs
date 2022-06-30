// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
string ShowNum3 (int fullnum)
{
  if (fullnum<100)
  {
    return ("третьей цифры в числе нет");
  }
  else
  {
    int thirdnum = (fullnum-(fullnum/1000)*1000)/100;
    return (thirdnum+" - третья цифра числа");
  }
}
Console.WriteLine(ShowNum3(num));