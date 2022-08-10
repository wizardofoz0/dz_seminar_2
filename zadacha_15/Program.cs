/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

string VacationCheck(int number)
{
    string answer = "";
    if ((number>7)|(number<1)) 
    {
        answer = "ошибка ввода";
        return answer;
    }
    if ((number == 6)|(number == 7))
    {
        answer = "да";
    }
    else 
    {
       answer = "нет"; 
    }
    return answer;
}
int number = new Random().Next(-2, 10);
string answer = VacationCheck(number);
Console.WriteLine($"День недели {number} выходной? - {answer}");