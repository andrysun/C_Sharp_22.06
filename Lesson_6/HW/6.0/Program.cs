// 0. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//    0, 7, 8, -2, -2 -> 2
//    1, -7, 567, 89, 223-> 3

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {arr[i]}");
    }
}
int Count(int[] massive)
{
    int count = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if(massive[i] > 0) count++;
    }
    return count;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i + 1}-й элемент");
    }
    return array;
}

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}

int[] array;
int length = Prompt("Введите количество элементов");
array = FillArray(length);
PrintArray(array);
Console.WriteLine($"Количество чисел больше нуля - {Count(array)}");