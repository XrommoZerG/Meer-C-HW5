// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] GetRandomArray(int lenght)
{
    double[] mass = new double[lenght];

    for (int i = 0; i < lenght; i++)
    {

        mass[i] = (double)Random.Shared.Next(100, 1000);
        mass[i] = mass[i] + (double)Random.Shared.Next(0,100)/100;

    }
    return mass;
}

double GetRazMinMax(double[] mass)
{
    double min = mass[0];
    double max = mass[0];
    double raz = 0;

    for (int i = 0; i < mass.Length; i++)
    {
        if (max<mass[i])
        {
            max = mass[i];
        }
        if (min> mass[i])
        {
            min = mass[i];
        }
    }
    raz = max - min;
    return raz;
}


int lenght = 12;
double[] array = new double[lenght];
array = GetRandomArray(lenght);

double result = GetRazMinMax(array);

Console.WriteLine("Выводим масив");
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Разница между максимальным и минимальны числом составляет - {result}");

