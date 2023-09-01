// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива " + "size = ");
int size = int.Parse(Console.ReadLine());
int[] numbers = new int[size];

void FillArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

FillArray(numbers);
Console.WriteLine("Сгенерированный массив: ");
PrintArray(numbers);

int count = 0;
for (int i = 0; i < numbers.Length; i++)
    if (numbers[i] % 2 == 0)
        count++;

Console.WriteLine($"четных чисел в массиве = {count}");