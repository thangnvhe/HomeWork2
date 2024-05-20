using System;

public abstract class Person
{
    protected string name;
    protected string address;

    public Person(string name, string address)
    {
        this.name = name;
        this.address = address;
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetAddress()
    {
        return address;
    }

    public void SetAddress(string address)
    {
        this.address = address;
    }

    public abstract void Display();
}

public class Employee : Person
{
    private int paymentPerHour;

    public Employee(string name, string address, int paymentPerHour)
        : base(name, address)
    {
        this.paymentPerHour = paymentPerHour;
    }

    public int GetPaymentPerHour()
    {
        return paymentPerHour;
    }

    public void SetPaymentPerHour(int paymentPerHour)
    {
        this.paymentPerHour = paymentPerHour;
    }

    public override void Display()
    {
        Console.WriteLine($"Name: {name}, Address: {address}, Payment per Hour: {paymentPerHour}");
    }
}

public class Customer : Person
{
    private decimal balance;

    public Customer(string name, string address, decimal balance)
        : base(name, address)
    {
        this.balance = balance;
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public void SetBalance(decimal balance)
    {
        this.balance = balance;
    }

    public override void Display()
    {
        Console.WriteLine($"Name: {name}, Address: {address}, Balance: {balance}");
    }
}

