using System;

public interface IEmployee
{
    int CalculateSalary();
    string GetName();
}

public abstract class Employee : IEmployee
{
    protected string name;
    protected int paymentPerHour;

    public Employee(string name, int paymentPerHour)
    {
        this.name = name;
        this.paymentPerHour = paymentPerHour;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void SetPaymentPerHour(int paymentPerHour)
    {
        this.paymentPerHour = paymentPerHour;
    }

    public int GetPaymentPerHour()
    {
        return paymentPerHour;
    }

    public abstract int CalculateSalary();

    public override string ToString()
    {
        return $"Name: {name}, Pay per hour: {paymentPerHour}";
    }
}
