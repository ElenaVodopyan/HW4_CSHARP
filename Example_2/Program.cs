// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

string str = GetNumber("Введите число для нахождения его сумм цифр");
int sum = SumStr(str);
Console.WriteLine(sum);

string GetNumber(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}


int SumStr(string str)
{
    int sum = 0;
    for (int i = 0; i < str.Length; i++)
    {
        sum = sum + Convert.ToInt32(Convert.ToString(str[i]));
    }
    return sum;
}
