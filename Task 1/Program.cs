/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Write("Введите пятизначное число: ");
int user_number = Convert.ToInt32(Console.ReadLine());

void is_polindrome(int user_number)
{
    int res1 = user_number % 100;
    int res2 = user_number / 1000 % 100;
    if (res2 < 10 || user_number / 1000 > 99)
    {
        Console.WriteLine($"Ошибка! Число {user_number} не пятизначное.");
    }
    else
    {
        int res2_rev = res2;
        while (res2_rev > 0)
        {
            res2 *= 10;
            res2 += res2_rev % 10;
            res2_rev /= 10;
            res2 = res2 % 100;
        }
        if (res1 == res2)
        {
            Console.WriteLine($"Число {user_number} является палиндромом.");
        }
        else
        {
            Console.WriteLine($"Число {user_number} не является палиндромом.");
        }
    }
}

is_polindrome(user_number);