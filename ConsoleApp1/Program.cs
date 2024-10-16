namespace ConsoleApp1;

class Program
{
    static int Main(string[] args)
    {
        //Employee e = new(1, "Mostafa Ehab", new HireDate(2004, 12, 13), "Male");
        Console.Write("Enter the number of employees: ");
        int num = int.Parse(Console.ReadLine() ?? "1");

        Employee[] emp = new Employee[num];

        for (int i = 0; i < num; i++)
        {

            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();

            Console.Write("Enter salary: ");
            int salary = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter hiring date: ");
            HireDate hireDate = new HireDate(Console.ReadLine());

            Console.Write("Enter employee gender: ");
            string gender = Console.ReadLine();

            emp[i] = new Employee(i, name, salary, hireDate, gender);
        }

        //sortEmployees(emp);

        for (int i = 0; i <  num; i++)
        {
            Console.Write(emp[i].ToString());
        }

        return 0;
    }

    static void sortEmployees(Employee[] emp)
    {
        throw new NotImplementedException();
    }
}
