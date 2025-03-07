public interface IEmployee
{
    int CalculateSalary();
    string GetName();
}

public class Employee : IEmployee
{
    private string name_237;
    private int paymentPerHour_237;

    public Employee(string name_237, int paymentPerHour_237)
    {
        this.name_237 = name_237;
        this.paymentPerHour_237 = paymentPerHour_237;
    }

    public void SetName(string name_237)
    {
        this.name_237 = name_237;
    }

    public string GetName()
    {
        return name_237;
    }

    public void SetPaymentPerHour(int paymentPerHour_237)
    {
        this.paymentPerHour_237 = paymentPerHour_237;
    }

    public int GetPaymentPerHour()
    {
        return paymentPerHour_237;
    }

    public virtual int CalculateSalary()
    {
        return 0; 
    }
}

public class PartTimeEmployee : Employee
{
    private int workingHours_237;

    public PartTimeEmployee(string name, int paymentPerHour, int workingHours)
        : base(name, paymentPerHour)
    {
        this.workingHours_237 = workingHours;
    }

    public override int CalculateSalary()
    {
        return GetPaymentPerHour() * workingHours_237;
    }
}
public class FullTimeEmployee : Employee
{
    private const int FullTimeHours_237 = 40;

    public FullTimeEmployee(string name, int paymentPerHour)
        : base(name, paymentPerHour)
    {
    }

    public override int CalculateSalary()
    {
        return GetPaymentPerHour() * FullTimeHours_237;
    }
}
class Program
{
    static void Main()
    {
        PartTimeEmployee partTimeEmp_237 = new PartTimeEmployee("Alice", 20, 25);
        FullTimeEmployee fullTimeEmp_237 = new FullTimeEmployee("Bob", 30);

        Console.WriteLine($"{partTimeEmp_237.GetName()} - Lương: {partTimeEmp_237.CalculateSalary()}");
        Console.WriteLine($"{fullTimeEmp_237.GetName()} - Lương: {fullTimeEmp_237.CalculateSalary()}");
    }
}