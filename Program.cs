internal class Program
{
    public static void Main()
    {
        Console.WriteLine("internal class Program\n{{\n    public static void Main()\n    {{\n        Console.WriteLine({0}, @{1}{1}{0}{1}{1}, @{1}{1}{1}{1});\n    }}\n}}", @"""internal class Program\n{{\n    public static void Main()\n    {{\n        Console.WriteLine({0}, @{1}{1}{0}{1}{1}, @{1}{1}{1}{1});\n    }}\n}}""", @"""");
    }
}
