// 3. Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

void FillArray(int[] filling)
{
    for (int i = 0; i < filling.Length; i++)
    {
        filling[i] = new Random().Next(-50, 123);
    }
}
void PrintArray(int[] printing)
{
    Console.Write("Array of numbers: [ ");
    for (int i = 0; i < printing.Length; i++)
    {
        Console.Write(printing[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
int CheckAndCountNum(int[] nums)
{
    int count = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] >= 10 && nums[i] <= 99) count++;
    }
    return count;
}
int[] array = new int[123];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Count of numbers in range [10; 99] -> {CheckAndCountNum(array)}");