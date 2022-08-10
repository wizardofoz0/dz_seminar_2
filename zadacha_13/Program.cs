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
    if (number3/100 > 0) 
  {
    res1=number3;
    Console.WriteLine(res1);

    while (res1>1000)
    {
        res1=res1/10;
        Console.WriteLine(res1);
    }
    res1 = res1 % 10;
    res = Convert.ToString(res1);
  }
  else
  {
    res = "третьей цифры нет";
    }
    return res;

}
int number3 = new Random().Next(10000,99999);
string second = GetThirdNumber(number3);
Console.WriteLine($"Из числа {number3} получили: {second}");