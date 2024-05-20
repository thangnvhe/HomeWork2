using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
        List<Customer> customers = new List<Customer>();

        while (true)
        {
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Add Customer");
            Console.WriteLine("3. Find Employee with Highest Salary");
            Console.WriteLine("4. Find Customer with Lowest Balance");
            Console.WriteLine("5. Find Employee by Name");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddEmployee(employees);
                    break;
                case 2:
                    AddCustomer(customers);
                    break;
                case 3:
                    FindHighestPaidEmployee(employees);
                    break;
                case 4:
                    FindCustomerWithLowestBalance(customers);
                    break;
                case 5:
                    FindEmployeeByName(employees);
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void AddEmployee(List<Employee> employees)
    {
        try
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter address: ");
            string address = Console.ReadLine();
            Console.Write("Enter payment per hour: ");
            int paymentPerHour = int.Parse(Console.ReadLine());

            Employee emp = new Employee(name, address, paymentPerHour);
            employees.Add(emp);

            Console.WriteLine("Employee added successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void AddCustomer(List<Customer> customers)
    {
        try
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter address: ");
            string address = Console.ReadLine();
            Console.Write("Enter balance: ");
            decimal balance = decimal.Parse(Console.ReadLine());

            Customer cust = new Customer(name, address, balance);
            customers.Add(cust);

            Console.WriteLine("Customer added successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void FindHighestPaidEmployee(List<Employee> employees)
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("No employees available.");
            return;
        }

        Employee highestPaidEmployee = employees.OrderByDescending(e => e.GetPaymentPerHour()).First();
        Console.WriteLine("Employee with the highest salary:");
        highestPaidEmployee.Display();
    }

    static void FindCustomerWithLowestBalance(List<Customer> customers)
    {
        if (customers.Count == 0)
        {
            Console.WriteLine("No customers available.");
            return;
        }

        Customer customerWithLowestBalance = customers.OrderBy(c => c.GetBalance()).First();
        Console.WriteLine("Customer with the lowest balance:");
        customerWithLowestBalance.Display();
    }

    static void FindEmployeeByName(List<Employee> employees)
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
                employee.Display();
            }
        }
    }
}

