internal class Program
{
    private static void Main(string[] args)
    {
        int x;
        int y;

        x = 7;
        y = x + 5;

        Console.WriteLine(y);
        Console.ReadLine();

        Console.Write("Type your first name: ");
        string? firstName;
        firstName = Console.ReadLine();

        Console.Write("Type your last name: ");
        string? lastName;
        lastName = Console.ReadLine();

        Console.WriteLine("Hello, " + firstName + " " + lastName);
        Console.ReadLine();
    }
}