Console.WriteLine("Введите любое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int firstnumber = 1;

while (firstnumber <= numberA)
{
    if (firstnumber % 2 == 0)
        Console.Write(firstnumber + " ");
    firstnumber++;
}
