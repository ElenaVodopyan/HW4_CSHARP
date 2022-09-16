// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] array = new int[8];
FillArray(array);
ShowArray(array);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,1000);
    }
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
