// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] array = new int[4];
int size = 4;
int sum = 0;
int sum_1 = 0;

void FillArray()
{
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
}

void OddArray()
{
    for (int i = 0; i < size; i++)
    {
        if (i % 2 == 0)
        {
            sum = sum + array[i];
        } 
        else
        {
            sum_1 = sum_1 + array[i];
        }
    }
    Console.Write($" -> {sum_1}");
}

void PrintArray()
{
    Console.Write($"[ ");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write($"]");
}

FillArray();
PrintArray();
OddArray();