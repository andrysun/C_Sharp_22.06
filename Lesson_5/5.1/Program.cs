// 1. Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.

void FillArray(int[] filling, int from, int to)
{
    for (int i = 0; i < filling.Length; i++)
    {
        filling[i] = new Random().Next(from, to + 1);
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
}
void ChangeNums(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = nums[i] * -1;
    }
    Console.WriteLine();
    
    Console.Write("Array with changed numbers: [ ");
    for (int i = 0; i < nums.Length; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.Write("]");
}

Console.WriteLine("Input size of line with numbers:");
int size = int.Parse(Console.ReadLine()!);
int[] array = new int[size];

Console.WriteLine("Input the range of numbers from and to:");
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
FillArray(array, start, stop);
PrintArray(array);
ChangeNums(array);