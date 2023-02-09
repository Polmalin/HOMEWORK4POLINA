// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

PrintArray(InitArray());

String [] InitArray()
{
    int length = 8; // Переменной передаётся значение равное длине массив
    while (true)
    {
        Console.WriteLine("Введите числа через запятую");
        String [] strArray = Console.ReadLine().Split(',');
        if (strArray.Length!=8)
        {
            Console.WriteLine("Вы ввели не 8 элементов");
        }
        else 
        {
            return strArray;
        } 
    }
}

void PrintArray(String [] array)
{
for (int i = 0; i < array.Length; i++ )
{
Console.WriteLine(array[i]);
}

}

