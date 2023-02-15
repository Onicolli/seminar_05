
using System.Drawing;
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
int[] array = new int[5];
int size = 5;

int FillArray()
{
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    Console.Write("[");
    Console.Write(String.Join(" ", array));
    Console.Write("]");
    return array[4];
}

int DifferenceValue()
{
    int dif = array.Max() - array.Min();
    Console.WriteLine($" -> {dif}");
    return dif;
}

FillArray();
DifferenceValue();