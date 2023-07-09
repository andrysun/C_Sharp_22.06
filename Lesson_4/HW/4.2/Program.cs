// 2. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int[] filling)
{
    for (int i = 0; i < filling.Length; i++)
    {
        filling[i] = int.Parse(Console.ReadLine()!);
    }
}

void PrintArray(int[] printing)
{
    Console.Write("Ваш массив выглядит так: [ ");
    for (int i = 0; i < printing.Length; i++)
    {
        Console.Write(printing[i] + " ");
    }
    Console.WriteLine("]");
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);