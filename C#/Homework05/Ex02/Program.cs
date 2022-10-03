// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

FillArray(numbers);
Console.WriteLine("Вот наш массив: ");

PrintArray(numbers);

int sum = 0;
for (int j = 0; j < numbers.Length; j++)
{
    if (j % 2 != 0) sum += numbers[j];
}

Console.WriteLine($"Всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void FillArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 10);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}