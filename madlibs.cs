namespace myprogram
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a color: ");
            string? color = Console.ReadLine();
            Console.Write("Enter another color: ");
            string? color2 = Console.ReadLine();
            Console.Write("Enter something you like: ");
            string? thing = Console.ReadLine();
            Console.Write("Enter a name: ");
            string? person = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine("Violets are " + color2);
            Console.WriteLine("I like " + thing);
            Console.WriteLine("I love  " + person);
        }
    }
}

