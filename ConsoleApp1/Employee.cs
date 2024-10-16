using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct HireDate
    {
        public int Year { get; set;  }
        public int Month { get; set; }
        public int Day { get; set; }

        public HireDate(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public HireDate(string date)
        {
            string[] datePart = date.Split("/");

            Day = int.Parse(datePart[0]);
            Month = int.Parse(datePart[1]);
            Year = int.Parse(datePart[2]);
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
    internal class Employee
    {
        public int Id { get; init; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public HireDate HireDate { get; set; }
        public string Gender { get; set; }
        public Employee(int id, string name, int salary, HireDate hireDate, string gender)
        {
            Id = id;
            Name = name;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        public Employee(int id, string name, HireDate hireDate, string gender): this(id, name, 0, hireDate, gender) {}

        public override string ToString()
        {
            string txt = "";

            txt += $"{Id} - {Name} - ({Gender})\n";
            txt += $"Salary: {Salary}\n";
            txt += $"Date: {HireDate}\n";

            return txt ;
        }

    }
}
