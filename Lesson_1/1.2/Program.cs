// 2. Напишите программу, которая будет выдавать название дня
//    недели по заданному номеру.

Console.WriteLine("Write number of day & this programm input name of day");
string day_of_week = Console.ReadLine()!;

switch (day_of_week)
{
    case "1":
    Console.WriteLine("Monday");
    break;

    case "2":
    Console.WriteLine("Tuesday");
    break;

    case "3":
    Console.WriteLine("Wensday");    
    break;

    case "4":
    Console.WriteLine("Thursday");
    break;

    case "5":
    Console.WriteLine("Friday");
    break;

    case "6":
    Console.WriteLine("Saturday");
    break;

    case "7":
    Console.WriteLine("Sunday");
    break;

    default:
    Console.WriteLine("Such day of week doesn`t exist");
    break;

}