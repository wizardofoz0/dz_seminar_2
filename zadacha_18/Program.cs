using static System.Console;
Clear();

WriteLine("Введите число: ");
int a = Convert.ToInt32(ReadLine());
switch (a)
{
    case 1:
        {
            WriteLine("X > 0 и Y > 0");
            break;
        }
    case 2:
        {
            WriteLine("X < 0 и Y > 0");
            break;
        }
    case 3:
        {
            WriteLine("X < 0 и Y < 0");
            break;
        }
    case 4:
        {
            WriteLine("X > 0 и Y < 0");
            break;
        }
         default: {
    WriteLine("Нет такой четверти");
    break;}
}


//int quarter = x > 0 && y > 0 ? 1 : x < 0 && y > 0 ? 2 : x < 0 && y < 0 ? 3 : 4;
//WriteLine($"Искомая четверть {quarter}");
