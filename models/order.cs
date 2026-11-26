namespace orderprocessing.models;

public class Order
{
    public int orderid{get;set;}
    public DateTime OrderDate{get;set;}
    public decimal Amount{get;set;}
    public string customername{get;set;}
}