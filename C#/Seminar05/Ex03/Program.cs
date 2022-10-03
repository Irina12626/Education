// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].

// 1. Создать массив 
// 2. Заполнить массив числами
// 3. Печать массива
// 4. Финалочка

// 1.
int[] Create(int len)
{
    return new int[len];
}
// 2.
void Fill(int[] array, int min, int max)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

// 3.
string Print(int[] array)
{
    return "[" + String.Join(", ", array) + "]";
    // string result = "[";

    // for (int i = 0; i < array.Length; i++)
    // {
    //    if (i < array.Length - 1) result = result + array[i] + ", ";
    //    else result = result + array[i];
    // }
    // return result + "]";
}

// 4.
int Search(int[] array, int findMin, int findMax)
{
    int size = array.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if
        (array[i] >= findMin && array[i] <= findMax)
        {
            count++;
        }
    }
    return count;
}

int[] arr = Create(12);
System.Console.WriteLine(Print(arr));
Fill(arr, 1, 200);
System.Console.WriteLine(Print(arr));
System.Console.WriteLine(Search(arr, 10, 99));


//System.Console.WriteLine(Print(new int[] { 1, 2, 3 }));
// Console.WriteLine(String.Join(',', new int[] { 1, 2, 3 }));

