Console.WriteLine("Напишите цифру дня недели и она подскажет вам, является ли этот день выходным");
int day_of_week = int.Parse(Console.ReadLine()!);

switch (day_of_week)
{
    case 1:
    Console.WriteLine("Нет");
    break;

    case 2:
    Console.WriteLine("Нет");
    break;

    case 3:
    Console.WriteLine("Нет");    
    break;

    case 4:
    Console.WriteLine("Нет");
    break;

    case 5:
    Console.WriteLine("Нет");
    break;

    case 6:
    Console.WriteLine("Да");
    break;

    case 7:
    Console.WriteLine("Да");
    break;

    default:
    Console.WriteLine("Такого дня недели не сущетсвует");
    break;

}