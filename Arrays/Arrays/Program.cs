// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int[] ages = new int[] { 1, 20, 39, 40, 51 };

/*
for (int i = 0; i < ages.Length; i++)
{
    Console.WriteLine(ages[i]);
}
Console.ReadLine();
*/

//foreach (int age in ages)
//{
//    Console.WriteLine(age);
//}

// Reserve a string
string zig = "The day of the finest people!";

char[] zigChars = zig.ToCharArray();
Array.Reverse(zigChars);

foreach (char c in zigChars)
{
    Console.Write(c);   
}
