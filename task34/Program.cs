// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] GetRandomArray(int lenght)
{

    int[] mass = new int[lenght];

    for (int i = 0; i < lenght; i++)
    {
        mass[i] = Random.Shared.Next(100, 1000);

    }
    return mass;
}

int Chet(int[] mass)
{
    int count = 0;

    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] % 2 == 0)
        {
            count++;
        }
    }


    return count;
}

int lenght = 12;
int[] array = new int[lenght];
array = GetRandomArray(lenght);

Console.WriteLine("Масив ");
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Количество чётных чисел = {Chet(array)}");