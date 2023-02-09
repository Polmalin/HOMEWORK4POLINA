// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int a = GetNumber("Введите число А: ");
int b = GetNumber("Введите число B: ");
Console.WriteLine($"Число {a} в степени {b} это {getNaturalDegree (a, b)}");


int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или 0. Повторите ввод");
        }
    }
    return result;
}

int getNaturalDegree (int value, int degree)
{
    int result = 1;
    for (int i = 0; i < degree; i++)
    {
        result = result * value;
    }
    return result;
}