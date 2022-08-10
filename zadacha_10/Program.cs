/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
int GetSecondNumber(int number3)
{
    int res = (number3 - (number3/100) *100 - number3%10)/10;
    //System.Console.WriteLine(res);
    return res;
}
int number3 = new Random().Next(100, 1000);
int second = GetSecondNumber(number3);
Console.WriteLine($"Из числа {number3} получили {second}");