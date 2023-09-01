// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.WriteLine("Введите размер массива " + "size = ");
// int size = int.Parse(Console.ReadLine());
// int[] numbers = new int[size];

// void FillArray(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100, 1000);
//     }
// }

// void PrintArray(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.WriteLine();
// }

// FillArray(numbers);
// Console.WriteLine("Сгенерированный массив: ");
// PrintArray(numbers);

// int count = 0;
// for (int i = 0; i < numbers.Length; i++)
//     if (numbers[i] % 2 == 0)
//         count++;

// Console.WriteLine($"четных чисел в массиве = {count}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.WriteLine("Введите размер массива size = ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];

// void FillArray(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(0,10);
//     }
// }

// void PrintArray(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.WriteLine();
// }

// FillArray(numbers);
// Console.WriteLine("Сгенерированный массив: ");
// PrintArray(numbers);

// int sum = 0;

// for (int i = 1; i < numbers.Length; i = i + 2)
//     sum = sum + numbers[i];

// Console.WriteLine($"сумма чисел, тоящих на нечетных позициях в массиве = {sum}");


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.WriteLine("Введите размер массива size = ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];

FillArray(numbers);
Console.WriteLine("Сгенерированный массив: ");
PrintArray(numbers);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
double res = max - min;

Console.WriteLine($"разница между максимальным и минимальным числом массива равна: {max} - {min} = {res}");

void FillArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
}

void PrintArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.WriteLine();
}

