// ## Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
string HowManyNumbersMoreThanZero(int M)
{
    int i = 0;
    int number = 0;
    int count = 0;
    for (i = 1; i <= M; i++)
    {
        Console.WriteLine($"Введите число #{i}: ");
        number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) count++;
    }
    return $"Количество чисел больше 0: {count}";
}
Console.WriteLine("Сколько введете чисел?");
int M = Convert.ToInt32(Console.ReadLine());

try
{
    Console.WriteLine(HowManyNumbersMoreThanZero(M));
}
catch
{
    Console.WriteLine("error. Not number");
}

// Console.WriteLine("Сколько введете чисел?");
// int M = Convert.ToInt32(Console.ReadLine());
// int i = 0;
// int number = 0;
// int count = 0;
// for (i = 0; i < M; i++)
// {
//     Console.WriteLine("Введите число: ");
//     number = Convert.ToInt32(Console.ReadLine());
//     if (number > 0) count++;
// }
// Console.WriteLine($"Количество чисел больше 0: {count}");