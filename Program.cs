internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Hello, " + name + "!");
        Console.WriteLine("Today is: " + DateTime.Now.ToString("dddd, dd MMMM yyyy"));
        Console.WriteLine("This is Anas, exploring GIT Branches!");
    }
}