// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetRandomArray(int lenght)
{

    int[] mass = new int[lenght];

    for (int i = 0; i < lenght; i++)
    {
        mass[i] = Random.Shared.Next(100, 1000);

    }
    return mass;
}

int Sum(int[] mass)
{
    int result = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (i % 2 != 0 && i != 0)
        {
            result += mass[i];
        }

    }


    return result;

}

int lenght = 12;
int[] array = new int[lenght];
array = GetRandomArray(lenght);

int sum = Sum(array);

Console.WriteLine(string.Join(",", array));
Console.WriteLine($"Сума чисел = {sum}");

