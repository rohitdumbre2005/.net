using HR;
public class Program
{
    public static void Main(string [] args )
    {
        Employee employee = new Employee(201, "Rohit", "Dumbre", "rohitdumbre2004@gmail.com", 50000,4400,1000,22,500000);
    
 employee.DisplayEmployeeDetails();

    decimal grossSalary = employee.ComputeBasicPay();
    Console.WriteLine("Gross Salary: "+grossSalary);

    decimal pay=employee.ComputePay();
    Console.WriteLine("Compute Pay: "+pay);

    string fullname=employee.GetFullName();
    Console.WriteLine("fullname: "+fullname);
    

    decimal annualSalary=employee.ComputeAnnualSalary();
    Console.WriteLine("compute Annual Salary: "+annualSalary); 
    }

}
