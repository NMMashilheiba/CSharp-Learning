// See https://aka.ms/new-console-template for more information
Console.WriteLine("");
Console.Write("Choose a door 1, 2 or 3: ");

string? userValue = Console.ReadLine();
string message;

if (userValue == "1")
{
    message = "You have won a car!";
}
else if (userValue == "2")
{
    message = "You have won a boat!";
}
else if(userValue == "3")
{
    message = "You have won a goat!";
}
else
{
    message = "Sorry, we didn't understand.";
}

Console.WriteLine(message);
Console.ReadLine();

string message1 = (userValue == "1") ? "Plane" : "goat";

// String replacement
Console.Write("You have entered {0}, therefore, you won a {1}.", userValue, message1);
Console.ReadLine();


