/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

void table_of_squares(int initial_number, int user_number)
{
    Console.Write($"Таблица кубов от 1 до {user_number}: ");
    while (initial_number <= user_number)
    {
        int res = initial_number * initial_number * initial_number;
        initial_number++;
        Console.Write($"{res} ");
    }
}

Console.Write("Введите число: ");
int user_number = Convert.ToInt32(Console.ReadLine());
int initial_number = 1;
table_of_squares(initial_number, user_number);