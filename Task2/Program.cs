// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int a = getSumFromConsole("Введите число: ");
Console.WriteLine($"Cумма цифр это {a}");

int getSumFromConsole(string message)
{
    int result = 0;
    int length;
    while (true)
    {
        Console.WriteLine(message);
        string input = Console.ReadLine();
        length = input.Length;
        if (int.TryParse(input, out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }
    return getSum(result, length);
}

int getSum (int value, int length)
{
int sum=0;
for (int i = 0; i < length; i++)
{
   sum = sum + (value %10);// 0+5//6
   value= value/10;//10//
}
return sum;
}