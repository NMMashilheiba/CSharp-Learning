using System.Timers;
using Timer = System.Timers.Timer;
internal class Program
{   
    // Timer Event Example
    private static void Main(string[] args)
    {
        System.Timers.Timer myTimer = new Timer(3000);
        Timer myTimer1 = new Timer(1000);

        myTimer.Elapsed += MyTimer_Elapsed;
        myTimer1.Elapsed += MyTimer_Elapsed1; ;
        myTimer.Start();
        myTimer1.Start();

        Console.ReadLine();

    }

    private static void MyTimer_Elapsed1(object? sender, ElapsedEventArgs e)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Elapsed1: {0:HH:mm:ss:ffff}", e.SignalTime);
    }

    private static void MyTimer_Elapsed(object? sender, ElapsedEventArgs e)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Elapsed: {0:HH:mm:ss:ffff}", e.SignalTime);
    }
}