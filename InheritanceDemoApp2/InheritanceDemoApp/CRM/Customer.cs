namespace CRM;



//Compostion:
// 1. Container Class : A class that contains an instance of another class as a property.
// 2. Component Class : A class that is used as a property within another class,
public class Customer
{
    public string Name { get; set; }
    public string Email { get; set; }

    // Composition : The Customer class has a Date object as a property,
    //                representing the join date of the customer.
    public Date JoinDate { get; set; } // Composition : The Customer class has a Date object as a property, representing the join date of the customer.


    //Each custome has a join date

    public Customer(string name, string email, Date joinDate)
    {
        Name = name;
        Email = email;
        JoinDate = joinDate;
    }

    public void DisplayCustomerInfo()
    {
        Console.WriteLine($"Customer Name: {Name}, Email: {Email}");
        JoinDate.DisplayDate();
    }
}