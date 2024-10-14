using ConsoleApp1;

namespace Program;

class Program
{
    public static void Main(string[] args)
    {
        Duration d1 = new(1, 10, 15);
        Console.WriteLine(d1.getStirng());

        Duration d2 = new(3600);
        Console.WriteLine(d2.getStirng());

        Duration d3 = new(7800);
        Console.WriteLine(d3.getStirng());

        Duration d4 = new(666);
        Console.WriteLine(d4.getStirng());

    }
}

