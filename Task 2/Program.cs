/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

void points_in_3D_space(double user_numberA1, double user_numberA2, double user_numberA3, double user_numberB1,
double user_numberB2, double user_numberB3)
{
    double res1 = Math.Pow(user_numberB1 - user_numberA1, 2);
    double res2 = Math.Pow(user_numberB2 - user_numberA2, 2);
    double res3 = Math.Pow(user_numberB3 - user_numberA3, 2);
    double result = Math.Sqrt(res1 + res2 + res3);
    result = Math.Round(result, 2);
    Console.WriteLine($"Расстояние между точками в 3D пространстве = {result}");
}

Console.Write("Введите число A1: ");
double user_numberA1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число A2: ");
double user_numberA2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число A3: ");
double user_numberA3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число B1: ");
double user_numberB1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число B2: ");
double user_numberB2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число B3: ");
double user_numberB3 = Convert.ToDouble(Console.ReadLine());

points_in_3D_space(user_numberA1, user_numberA2, user_numberA3, user_numberB1, user_numberB2, user_numberB3);