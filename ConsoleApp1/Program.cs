namespace ConsoleApp1;

internal static class Program
{
    private static void Main(string[] args)
    {
        var stud1 = new Student("John");
        Console.WriteLine($"Hello, {stud1.Name}!");
    }
}