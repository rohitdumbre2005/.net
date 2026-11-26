namespace HR;

public class Employee
{
    public  int EmployeeId;
    public string Firstname;
    public string Lastname;
    public string Email;
    public decimal BasicSalary;
    public decimal HRA;
    public decimal DailyWages;
    public int WorkingDays;
    public decimal AnnualSalary;

    public Employee(int employeeId,string firstName, string lastName, string email,decimal basicSalary, decimal hra,
        decimal dailyWages, int workingDays, decimal annualSalary)
    {
        EmployeeId = employeeId;
        Firstname = firstName;
        Lastname = lastName;
        Email = email;
        BasicSalary = basicSalary;
        HRA = hra;
        DailyWages = dailyWages;
        WorkingDays = workingDays;
        AnnualSalary = annualSalary;
    }

    public decimal ComputeBasicPay()
    {
        decimal GrossPay = BasicSalary + HRA;
        return GrossPay;
    }

    public decimal ComputePay()
    {
        decimal pay = BasicSalary + HRA;
        return pay;
    }

    public decimal ComputeAnnualSalary()
    {
        AnnualSalary = BasicSalary * 12;
        return AnnualSalary;
    }

    public string GetFullName()
    {
        return Firstname + " " + Lastname;
    }

    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("EmployeeId: " + EmployeeId);
        Console.WriteLine("Name: " + Firstname + " " + Lastname);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("BasicSalary: " + BasicSalary);
        Console.WriteLine("HRA: " + HRA);
        Console.WriteLine("DailyWages: " + DailyWages);
        Console.WriteLine("WorkingDays: " + WorkingDays);
        Console.WriteLine("AnnualSalary: " + AnnualSalary);
    }
}