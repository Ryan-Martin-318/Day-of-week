// The Program will ask the User what day is it.
Console.Write("What day of the week is it?\nMonday -> 1\nTuesday -> 2\nWednesday -> 3\nThursday -> 4\nFriday -> 5\nSaturday -> 6\nSunday -> 7\n");
int day = 0;
do
{
    try
    {
        Console.Write("Enter the day of the week >> ");
        string input = Console.ReadLine();
        day = int.Parse(input);
    }
    catch (ArgumentNullException)
    {
        Console.WriteLine("You didnt put anything in.");
        day = 0;
    }
    catch (FormatException)
    {
        Console.WriteLine("You did not put in a number. Try agian!");
        day = 0;
    }
} while (day == 0);
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
        Console.WriteLine("That is not a day.");
        break;
}