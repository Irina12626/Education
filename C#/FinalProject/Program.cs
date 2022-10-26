/* ЗАДАЧА:
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

int CountLessThree(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] FillResultArray(string[] array, int count)
{
    string[] result = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[result.Length - count] = array[i];
            count--;
        }
    }
    return result;
}

string[] arrayFirst = { "hello", "2", "world", ":-)" };
int countFirst = CountLessThree(arrayFirst);
string[] resultFirst = FillResultArray(arrayFirst, countFirst);
PrintArray(resultFirst);

string[] arraySecond = { "1234", "1567", "-2", "computer science" };
int countSecond = CountLessThree(arraySecond);
string[] resultSecond = FillResultArray(arraySecond, countSecond);
PrintArray(resultSecond);

string[] arrayThird = { "Russia", "Denmark", "Kazan" };
int countThird = CountLessThree(arrayThird);
string[] resultThird = FillResultArray(arrayThird, countThird);
PrintArray(resultThird);

void PrintArray(string[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}.");
    }
    Console.WriteLine();
}



