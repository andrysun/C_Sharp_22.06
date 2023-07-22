// 1. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//    452 -> 11
//    82 -> 10
//    9012 -> 12

int Count(int num) // подсчёт цифр в числе
{
    int result = 0;
    for (int i = 1; num > 0; i++)
    {
        num /= 10;
        result = i;
    }
    return result;
}

int number = int.Parse(Console.ReadLine()!);
int count_of_digit = Count(number);
Console.WriteLine($"Количество разрядов: {count_of_digit}");

int sum = 0;
for (int i = 0; i < count_of_digit; i++)
{
    sum = sum + (number % 10);
    number /= 10;
}
Console.WriteLine($"Сумма цифр в числе: {sum}");

// --------------------------------- 3 вариант
// https://shwanoff.ru/char-c-sharp/

/*
double DigitSum(int num)
{
string n = num.ToString();
int length = n.Length;
double sum = 0;

for (int i = 0; i < length; i++)
{
double m = char.GetNumericValue(n[i]);
sum += m;
}

return sum;
}

int n = int.Parse(Console.ReadLine()!); ;

Console.WriteLine(DigitSum(n));

// --------------------------------- 2 вариант

int SumNums_2(int num)
{
int n_sum = 0;

for (; num != 0; num /= 10)
n_sum += num % 10;

return n_sum;
}


int num_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNums_2(num_2));

*/