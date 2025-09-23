// The Program will ask the User what day is it.
Console.WriteLine("What day of the week is it?");
Console.WriteLine("Monday -> 1");
Console.WriteLine("Tuesday -> 2");
Console.WriteLine("Wednesday -> 3");
Console.WriteLine("Thursday -> 4");
Console.WriteLine("Friday -> 5");
Console.WriteLine("Saturday -> 6");
Console.WriteLine("Sunday -> 6");
Console.WriteLine();
int day = Convert.ToInt32(Console.ReadLine());

// Using what the User said, the Program will look for the day, and tell the user that it is indeed that day.
switch (day)
{
    case 1:
        Console.WriteLine("Aack! I hate Mondays!");
        break;

    case 2:
        Console.WriteLine("Taco Tusedays.");
        break;

    case 3:
        Console.WriteLine("Hump Day!");
        break;

    case 4:
        Console.WriteLine("Oh, its Thursday, ok.");
        break;

    case 5:
        Console.WriteLine("TGIF!");
        break;

    case 6:
        Console.WriteLine("ITS THE WEEKEND!!!");
        break;

    case 7:
        Console.WriteLine("The weekend is almost over :(");
        break;

    default:
        Console.WriteLine("That isn't even a day.");
        break;
}