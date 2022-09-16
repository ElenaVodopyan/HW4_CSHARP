// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int A = GetNumber("Введитезначение A ");
int B = GetNumber("Введитезначение B ");
Console.WriteLine($"{A}^{B} = {Math.Pow(A, B)}");

int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
