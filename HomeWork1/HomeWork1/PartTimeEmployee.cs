public class PartTimeEmployee : Employee
{
    private int workingHours;

    public PartTimeEmployee(string name, int paymentPerHour, int workingHours)
        : base(name, paymentPerHour)
    {
        this.workingHours = workingHours;
    }

    public override int CalculateSalary()
    {
        return workingHours * paymentPerHour;
    }

    public override string ToString()
    {
        return base.ToString() + $", Working Hours: {workingHours}, Salary: {CalculateSalary()}";
    }
}

public class FullTimeEmployee : Employee
{
    public FullTimeEmployee(string name, int paymentPerHour)
        : base(name, paymentPerHour)
    {
    }

    public override int CalculateSalary()
    {
        return 8 * paymentPerHour;
    }

    public override string ToString()
    {
        return base.ToString() + $", Salary: {CalculateSalary()}";
    }
}
