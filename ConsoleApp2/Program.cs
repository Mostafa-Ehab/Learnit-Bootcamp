// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using ClassLibrary1;

namespace Program;

class Program
{
    public static void Main(string[] args)
    {
        Student s = new Student("12", "Mostafa Ehab", 12);

        Console.WriteLine(s.getStudent());
    }
}

