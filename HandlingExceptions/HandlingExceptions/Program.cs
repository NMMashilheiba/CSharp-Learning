internal class Program
{
    private static void Main(string[] args)
    {
		try
		{
			string content = File.ReadAllText(@"C:\Users\mashi\OneDrive\Documents\NuclearCod.txt");
			Console.WriteLine(content);
		}
		catch (FileNotFoundException exMsg )
		{
			Console.WriteLine("There was a problem.");
			Console.WriteLine(exMsg.Message);
		}
		catch (DirectoryNotFoundException exMsg)
		{
			Console.WriteLine("Directory not found, please check and try again.");
			Console.WriteLine(exMsg);
		}
		catch (Exception exMsg)
		{
			Console.WriteLine("There was a problem!");
			Console.WriteLine(exMsg);
		}
		finally
		{
			Console.WriteLine("Finally block: Finally block is always executed.");
		}

		Console.ReadLine();
    }
}