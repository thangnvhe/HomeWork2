using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<IEmployee> employees = new List<IEmployee>();

        while (true)
        {
            Console.WriteLine("1. Add Part-Time Employee");
            Console.WriteLine("2. Add Full-Time Employee");
            Console.WriteLine("3. Find Employee with Highest Salary");
            Console.WriteLine("4. Find Employee by Name");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddPartTimeEmployee(employees);
                    break;
                case 2:
                    AddFullTimeEmployee(employees);
                    break;
                case 3:
                    FindHighestSalaryEmployee(employees);
                    break;
                case 4:
                    FindEmployeeByName(employees);
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void AddPartTimeEmployee(List<IEmployee> employees)
    {
        try
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter payment per hour: ");
            int paymentPerHour = int.Parse(Console.ReadLine());
            Console.Write("Enter working hours: ");
            int workingHours = int.Parse(Console.ReadLine());

            PartTimeEmployee pte = new PartTimeEmployee(name, paymentPerHour, workingHours);
            employees.Add(pte);

            Console.WriteLine("Part-Time Employee added successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void AddFullTimeEmployee(List<IEmployee> employees)
    {
        try
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter payment per hour: ");
            int paymentPerHour = int.Parse(Console.ReadLine());

            FullTimeEmployee fte = new FullTimeEmployee(name, paymentPerHour);
            employees.Add(fte);

            Console.WriteLine("Full-Time Employee added successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void FindHighestSalaryEmployee(List<IEmployee> employees)
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("No employees available.");
            return;
        }

        IEmployee highestSalaryEmployee = employees.OrderByDescending(e => e.CalculateSalary()).First();
        Console.WriteLine("Employee with the highest salary:");
        Console.WriteLine(highestSalaryEmployee);
    }

    static void FindEmployeeByName(List<IEmployee> employees)
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        var foundEmployees = employees.Where(e => e.GetName().Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();

        if (foundEmployees.Count == 0)
        {
            Console.WriteLine("No employees found with the given name.");
        }
        else
        {
            Console.WriteLine("Employees found:");
            foreach (var employee in foundEmployees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}

