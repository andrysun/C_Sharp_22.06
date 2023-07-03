// 3. Напишите программу, которая выводит массив из 8 элементов,
//    заполненный нулями и единицами в случайном порядке.

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(0, 2);
        i++;
    }
}
void PrintArray(int[] printing)
{
    for (int i = 0; i < printing.Length; i++)
    {
        Console.Write($"{printing[i] + " "}");
    }
}
int[] array = new int[8];
FillArray(array);
PrintArray(array);