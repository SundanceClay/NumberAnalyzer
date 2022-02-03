// See https://aka.ms/new-console-template for more information
string userStop = "n";
do
{
    Console.Write("Enter an integer between 1 and 100: ");
    int userInt = int.Parse(Console.ReadLine());
    if (userInt <= 1 || userInt >= 100)
    {
        Console.WriteLine($"Your number, {userInt}, does not fit the criteria (between 1 and 100).");
    }
    else
    {
        if ((userInt < 60) && (userInt % 2 != 0))
            Console.WriteLine($"{userInt}: Odd and less than 60.");
        else if ((userInt < 25) && (userInt % 2 == 0))
            Console.WriteLine($"{userInt}: Even and less than 25.");
        else if ((userInt > 25) && (userInt <= 60) && (userInt % 2 == 0))
            Console.WriteLine($"{userInt}: Even and between 26 and 60 inclusive.");
        else if ((userInt > 60) && (userInt % 2 == 0))
            Console.WriteLine($"{userInt}: Even and greater than 60.");
        else if ((userInt > 60) && (userInt % 2 != 0))
            Console.WriteLine($"{userInt}: Odd and greater than 60.");
    }
    Console.WriteLine("Do you want to stop? (Enter y or n) ");
    userStop = Console.ReadLine().ToLower();
}
while (userStop == "n");
Console.WriteLine("Program stopped at your request.");