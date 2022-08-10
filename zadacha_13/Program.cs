/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
string GetThirdNumber(int number3)
{
    int res1 = number3 % 10;
    string res = Convert.ToString(res1);
    Console.WriteLine(number3/100);
    if ((number3/100 > 0)&(number3/100 <= 9))

  {
    res1 = number3 % 10;
    res = Convert.ToString(res1);

  }
  else {res = "третьей цифры нет";}
    return res;
}
int number3 = new Random().Next(1,10000);
string second = GetThirdNumber(number3);
Console.WriteLine($"Из числа {number3} получили: {second}");