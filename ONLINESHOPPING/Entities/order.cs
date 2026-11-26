namespace Entities;

public class Order
{
    public int OrderId { get; set; }

    public DateTime OrderDate { get; set; }

    public decimal Amount { get; set; }

    public string CustomerName { get; set; }
}