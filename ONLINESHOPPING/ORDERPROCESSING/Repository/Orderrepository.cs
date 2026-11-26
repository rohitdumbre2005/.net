
using Entities;
using Helpers;

namespace OrderProcessing.Repository;

public class OrderRepository
{
    string filePath = @"C:\GitHub\.net\ONLINESHOPPING\Data\order.json";

    public OrderRepository()
    {
    }

    public List<Order> GetAllOrders()
    {
        Console.WriteLine("get all method invoked");
        List<Order> allOrders = PersistManager.Load(filePath);
        return allOrders;
    }

    public Order GetOrderById(int orderid)
    {
        List<Order> allOrders = GetAllOrders();
        Order theOrder = null;
        for (int i = 0; i < allOrders.Count; i++)
        {
            if (allOrders[i].orderid == orderid)
            {
                theOrder = allOrders[i];
                return theOrder;
            }
        }
        return theOrder;
    }

    public bool Create(Order theOrder)
    {
        bool status = false;
        List<Order> allOrders = GetAllOrders();
        allOrders.Add(theOrder);
        PersistManager.Dump(filePath, allOrders);
        status = true;
        return status;
    }

    public bool Update(Order orderToUpdate)
    {
        bool status = false;
        Order existingOrder = GetOrderById(orderToUpdate.orderid);
        if (existingOrder != null)
        {
            existingOrder = orderToUpdate;
            List<Order> allOrders = GetAllOrders();
            PersistManager.Dump(filePath, allOrders);
            status = true;
        }

        return status;
    }

    public bool Delete(int id)
    {
        bool status = false;
        Order existingOrder = GetOrderById(id);
        if (existingOrder != null)
        {
            List<Order> allOrders = GetAllOrders();
            allOrders.Remove(existingOrder);
            PersistManager.Dump(filePath, allOrders);
            status = true;
        }
        return status;
    }
}
